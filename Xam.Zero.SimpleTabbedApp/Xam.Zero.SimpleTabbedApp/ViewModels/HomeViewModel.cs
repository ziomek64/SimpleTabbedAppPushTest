using System.Threading.Tasks;
using System.Windows.Input;
using Xam.Zero.SimpleTabbedApp.Pages;
using Xam.Zero.SimpleTabbedApp.Services;
using Xam.Zero.ViewModels;
using Xamarin.Forms;

namespace Xam.Zero.SimpleTabbedApp.ViewModels
{
    public class HomeViewModel: ZeroBaseModel
    {
        private readonly IDummyService _dummyService;

        public ICommand GetDummyDataCommand { get; private set; }
        public ICommand TestPushCommand { get; private set; }


        Person _Person = new Person
        {
            FavouriteColor = Color.Green,
            id = 1,
            name = "Michael"
        };

        private Person Person
        {
            get => _Person;
            set
            {
                _Person = value;
            }
        }
        
        public HomeViewModel(IDummyService dummyService)
        {
            this._dummyService = dummyService;
            this.GetDummyDataCommand = new Command(() =>
            {
                var dummyData = this._dummyService.GetDummyString();
                this.DisplayAlert("Info", dummyData, "OK");
            });

            TestPushCommand = new Command(async () => await PushTask().ConfigureAwait(false));


        }

         async Task PushTask()
         {
             Push<TestPushPage>(Person);
         }
        
        
        
    }
}