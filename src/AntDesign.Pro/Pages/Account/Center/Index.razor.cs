using System.Collections.Generic;
using System.Threading.Tasks;
using AntDesign.Pro.Services;
using Microsoft.AspNetCore.Components;

namespace AntDesign.Pro.Pages.Account
{
    public class CurrentUser
    {
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string Signature { get; set; }
        public string Title { get; set; }
        public string Group { get; set; }
        public string Geographic { get; set; }
    }

    public partial class Index
    {
        private CurrentUser currentUser = new CurrentUser
        {
            Avatar = "https://gw.alipayobjects.com/zos/antfincdn/XAosXuNZyF/BiazfanxmamNRoxxVxka.png",
            Name = "Serati Ma",
            Signature = "���ɰٴ��������˴�",
            Title = "����ר��",
            Group = "���Ͻ����ĳĳĳ��ҵȺ��ĳĳƽ̨����ĳĳ��������UED",
            Geographic = "�㽭ʡ������"
        };
        private bool inputVisible = false;
        private string inputValue = string.Empty;

        private string[] lstTags = new string[]
        {
            "�����뷨��",
            "רע���",
            "��~",
            "����",
            "������",
            "���ɰٴ�"
        };

        private IList<ListItemDataType> _fakeList = new List<ListItemDataType>();

        private void ShowInput()
        {

        }

        [Inject] public ProjectService ProjectService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            _fakeList = await ProjectService.GetFakeListAsync();
        }
    }
}