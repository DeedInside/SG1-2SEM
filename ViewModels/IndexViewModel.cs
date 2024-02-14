using SG1.models;

namespace SG1.ViewModels
{
    public class IndexViewModel
    {
        public IndexViewModel(List<User> user, List<Car> car)
        {
            this.user = user;
            this.car = car;
        }

        public List<User> user {  get; set; } 
        public List<Car> car {  get; set; }
    }
}
