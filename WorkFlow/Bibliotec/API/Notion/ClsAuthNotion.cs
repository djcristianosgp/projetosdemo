using Notion.Client;
using System.Collections.Generic;

namespace Bibliotec.API
{
    public class ClsAuthNotion
    {
        private string sNotionToken = "TOKEN";

        public List<string> SListaUser = new List<string>();

        public async void FU_Loga()
        {
            var client = NotionClientFactory.Create(new ClientOptions
            {
                AuthToken = sNotionToken
            });

            var usersList = await client.Users.ListAsync();
            foreach (var user in usersList.Results)
            {
                SListaUser.Add(user.Name);
            }
        }
    }
}
