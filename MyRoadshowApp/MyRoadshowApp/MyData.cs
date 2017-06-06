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
            Events.Add(new Event { Name = "VS 2017 Best Of Launch", Date = "5/22", ImageURL = "stlouis.jpg", Venue = "St Louis" });
            Events.Add(new Event { Name = "VS 2017 Best Of Launch", Date = "5/23", ImageURL = "kansascity.jpg", Venue = "Kansas City" });
            Events.Add(new Event { Name = "VS 2017 Best Of Launch", Date = "5/24", ImageURL = "omaha.jpg", Venue = "Omaha" });
            Events.Add(new Event { Name = "VS 2017 Best Of Launch", Date = "5/25", ImageURL = "desmoines.jpg", Venue = "Des Moines" });
            Events.Add(new Event { Name = "VS 2017 Best Of Launch", Date = "5/26", ImageURL = "minneapolis.png", Venue = "Minneapolis" });
            Events.Add(new Event { Name = "VS 2017 Best Of Launch", Date = "5/31", ImageURL = "chicago.jpg", Venue = "Austin" });
            Events.Add(new Event { Name = "VS 2017 Best Of Launch", Date = "6/1", ImageURL = "background.jpg", Venue = "Chicago" });
            Events.Add(new Event { Name = "VS 2017 Best Of Launch", Date = "6/2", ImageURL = "chicago.jpg", Venue = "Milwaukee" });
            Events.Add(new Event { Name = "VS 2017 Best Of Launch", Date = "6/5", ImageURL = "chicago.jpg", Venue = "New York" });
            Events.Add(new Event { Name = "VS 2017 Best Of Launch", Date = "6/7", ImageURL = "chicago.jpg", Venue = "Tampa" });
            Events.Add(new Event { Name = "VS 2017 Best Of Launch", Date = "6/9", ImageURL = "chicago.jpg", Venue = "Atlanta" });
            Events.Add(new Event { Name = "VS 2017 Best Of Launch", Date = "6/12", ImageURL = "chicago.jpg", Venue = "Portland" });
            Events.Add(new Event { Name = "VS 2017 Best Of Launch", Date = "6/14", ImageURL = "chicago.jpg", Venue = "San Diego" });
            Events.Add(new Event { Name = "VS 2017 Best Of Launch", Date = "6/15", ImageURL = "chicago.jpg", Venue = "Phoenix" });
            Events.Add(new Event { Name = "VS 2017 Best Of Launch", Date = "6/16", ImageURL = "chicago.jpg", Venue = "Denver" });

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
