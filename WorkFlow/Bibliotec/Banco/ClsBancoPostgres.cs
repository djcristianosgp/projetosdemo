using Bibliotec.Executa;
using Npgsql;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Bibliotec.Classes
{
    public class ClsBancoPostgres
    {
        public static string sConexao = "123";

        public static void StringConexao()
        {
            NpgsqlConnectionStringBuilder strConnection = new NpgsqlConnectionStringBuilder();

            strConnection.Host = "";
            strConnection.Database = "";
            strConnection.Port = 0;
            strConnection.Username = "";
            strConnection.Password = "";
            //strConnection.Pooling = false;
            //strConnection.Encoding = "windows-1252";
            //strConnection.ClientEncoding = "UTF8";
            sConexao = strConnection.ConnectionString;
        }

        public static bool FU_TestaConexao()
        {
            string connectionString = sConexao;
            bool bRetorno;
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(connectionString);
                conn.Open();
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        bRetorno = true;
                    }
                    else
                    {
                        bRetorno = false;
                    }
                    {
                        conn.Close();
                        conn.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                //clsLog.FU_Escreve_Log("FU_TestaConexao", ex.Message);
                bRetorno = false;
            }
            return bRetorno;
        }

        public static void Fu_FinalizaConexoes()
        {
            string sScript = "WITH inactive_connections AS (" +
                "SELECT pid,backend_start, rank() over " +
                "(partition by client_addr order by backend_start ASC) " +
                "as rank FROM pg_stat_activity WHERE pid <> pg_backend_pid( ) " +
                "AND application_name !~ '(?:psql)|(?:pgAdmin.+)' " +
                "AND datname = '{0}' " +
                "AND state in ('idle', 'idle in transaction', 'idle in transaction (aborted)', 'disabled') " +
                "AND current_timestamp - state_change > interval '48 hours') " +
                "SELECT pg_terminate_backend(pid) FROM inactive_connections WHERE rank > 0;";
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(sConexao);
                conn.Open();
                {
                    {
                        NpgsqlCommand command = new NpgsqlCommand(sScript, conn);
                        NpgsqlDataReader dr = command.ExecuteReader();
                    }
                    {
                        conn.Close();
                        conn.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                //clsLog.FU_Escreve_Log("Fu_FinalizaStatus", ex.Message);
            }
        }

        public static DataSet FU_ListaRelatorio(string sScript)
        {
            DataSet DS = new DataSet();
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(sConexao);
                conn.Open();
                {
                    NpgsqlCommand command = new NpgsqlCommand(sScript, conn);
                    NpgsqlDataAdapter DA = new NpgsqlDataAdapter(command);
                    DA.Fill(DS);
                    conn.Close();
                    conn.Dispose();
                    return DS;
                }
            }
            catch (Exception ex)
            {
                //clsLog.FU_Escreve_Log("FU_ListaRelatorio", ex.Message);
                return DS;
            }
        }

        public static bool RodaScriptGeral(string sScript)
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(sConexao);
                conn.Open();
                {
                    {
                        NpgsqlCommand command = new NpgsqlCommand(sScript, conn);
                        NpgsqlDataReader dr = command.ExecuteReader();
                    }
                    {
                        conn.Close();
                        conn.Dispose();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                //clsLog.FU_Escreve_Log("RodaScriptGeral", ex.Message);
                return false;
            }
        }

        public static void FU_BackupSistema(string sHost, int iPorta, string sBanco, string sUser)
        {
            string sPastaBINPostgresql = @"C:\Program Files\PostgreSQL\13\bin\";
            if (Directory.Exists(sPastaBINPostgresql))
            {
                StreamWriter sArquivo = new StreamWriter(/*clsUteis.sPastaPadrao*/  "Backup.bat");
                sArquivo.WriteLine("color 1f");
                sArquivo.WriteLine("Title Efetuando Backup");
                sArquivo.WriteLine("echo off");
                sArquivo.WriteLine("cls");
                sArquivo.WriteLine("c:");
                sArquivo.WriteLine("cd \\");
                sArquivo.WriteLine("cd \"" + sPastaBINPostgresql + "\" ");
                sArquivo.WriteLine("set PGUSER=" + sUser);
                sArquivo.WriteLine("set PGHOST=" + sHost);
                sArquivo.WriteLine("set PGPASSWORD=pg@rgDev");
                sArquivo.WriteLine("pg_dump.exe -p" + iPorta + " -F c -b -f " + /*clsUteis.sPastaPadrao */ "Base_RG_System.backup " + sBanco);
                //sArquivo.WriteLine("pause");
                sArquivo.Close();
                ClsBat.ExecutaBat(/*clsUteis.sPastaPadrao + */"Backup.bat");
            }
            else
            {
                MessageBox.Show("Não foi possível executar o backup pois a pasta BIN do PostgreSQL 13.1 não foi localizada");
            }
        }
        public static void FU_VacuumSistema(string sHost, int iPorta, string sBanco, string sUser)
        {
            string sPastaBINPostgresql = @"C:\Program Files\PostgreSQL\13\bin\";
            if (Directory.Exists(sPastaBINPostgresql))
            {
                StreamWriter sArquivo = new StreamWriter(/*clsUteis.sPastaPadrao +*/ "Vacuum.bat");
                sArquivo.WriteLine("color 1f");
                sArquivo.WriteLine("Title Efetuando VACUUM");
                sArquivo.WriteLine("echo off");
                sArquivo.WriteLine("cls");
                sArquivo.WriteLine("c:");
                sArquivo.WriteLine("cd \\");
                sArquivo.WriteLine("cd \"" + sPastaBINPostgresql + "\" ");
                sArquivo.WriteLine("set PGUSER=" + sUser);
                sArquivo.WriteLine("set PGHOST=" + sHost);
                sArquivo.WriteLine("set PGPASSWORD=pg@rgDev");
                sArquivo.WriteLine("vacuumdb.exe -h " + sHost + " -p " + iPorta + " -U " + sUser + " -d " + sBanco + " --verbose ");
                //sArquivo.WriteLine("pause");
                sArquivo.Close();
                ClsBat.ExecutaBat(/*clsUteis.sPastaPadrao +*/ "Vacuum.bat");
            }
            else
            {
                MessageBox.Show("Não foi possível executar o backup pois a pasta BIN do PostgreSQL 13.1 não foi localizada");
            }
        }

        public static void FU_AnalyzeBD()
        {
            string sScript = "ANALYZE VERBOSE;";
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(sConexao);
                conn.Open();
                {
                    {
                        NpgsqlCommand command = new NpgsqlCommand(sScript, conn);
                        NpgsqlDataReader dr = command.ExecuteReader();
                    }
                    {
                        conn.Close();
                        conn.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                //clsLog.FU_Escreve_Log("FU_AnalyzeBD", ex.Message);
            }
        }

        public static void FU_ReindexBD()
        {
            string sScript = "REINDEX DATABASE {0};";
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(sConexao);
                conn.Open();
                {
                    {
                        NpgsqlCommand command = new NpgsqlCommand(sScript, conn);
                        NpgsqlDataReader dr = command.ExecuteReader();
                    }
                    {
                        conn.Close();
                        conn.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                //clsLog.FU_Escreve_Log("FU_ReindexBD", ex.Message);
            }
        }
    }
}
