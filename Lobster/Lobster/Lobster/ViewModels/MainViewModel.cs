using Lobster.Extensions;
using Lobster.Models;
using Lobster.Services;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Lobster.ViewModels
{
    public class MainViewModel
    {
        private readonly ICrabService crabService;

        public ObservableCollection<Crab> Crabs { get; } = new ObservableCollection<Crab>();

        public MainViewModel(ICrabService crabService) => this.crabService = crabService;

        internal async Task Initialize()
        {
            var crabs = await crabService.GetCrabs();
            Crabs.AddRange(crabs);
        }
    }
}