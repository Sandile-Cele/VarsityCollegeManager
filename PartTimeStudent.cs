using Name;

namespace VarsityCollegeManager
{
    class PartimeStudent : Student{
        string onlineClassLink;

        public PartimeStudent(string onlineClassLink)
        {
            this.onlineClassLink = onlineClassLink;
        }
        
        public string OnlineClassLink { get => onlineClassLink; set => onlineClassLink = value; }

    }
}
        