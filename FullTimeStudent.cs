using Name;

namespace VarsityCollegeManager{
    class FullTimeStudent : Student{
        
        int venueNum;//Based on assumption that Full Time Students only have on venue

        public FullTimeStudent()
        {
        }
        public FullTimeStudent(int venueNum, Student inStudent) : base()
        {
            this.VenueNum = venueNum;
        }


        public int VenueNum { get => venueNum; set => venueNum = value; }
    }

}