using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MyRoadshowApp
{
    public class MyDataViewModel
    {
        public ObservableCollection<Event> Events { get; set; }
        public string Title { get; set; }
        public int Count { get { return Events.Count; } }

        public MyDataViewModel()
        {
            Title = "re-BUILD 2017 Roadshow";
            Events = new ObservableCollection<Event>();
            Events.Add(new Event { Name = "re-BUILD 2017", Date = "3/24", ImageURL = "minneapolis.png", Venue = "Minneapolis" });
            Events.Add(new Event { Name = "re-BUILD 2017", Date = "4/11", ImageURL = "desmoines.jpg", Venue = "Des Moines" });
            Events.Add(new Event { Name = "re-BUILD 2017", Date = "4/12", ImageURL = "omaha.jpg", Venue = "Omaha" });
            Events.Add(new Event { Name = "re-BUILD 2017", Date = "4/17", ImageURL = "chicago.jpg", Venue = "Chicago" });
            Events.Add(new Event { Name = "re-BUILD 2017", Date = "4/18", ImageURL = "stlouis.jpg", Venue = "St Louis" });
            Events.Add(new Event { Name = "re-BUILD 2017", Date = "4/19", ImageURL = "kansascity.jpg", Venue = "Kansas City" });
        }
    }
    public class Event
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string ImageURL { get; set; }
        public string Venue { get; set; }
    }
}
