﻿using System.Collections.ObjectModel;

namespace CollectionViewScrollIssue
{
    public class MainViewModel
    {
        public ObservableCollection<ParentItem> ParentItems { get; set; }

        public MainViewModel()
        {
            ParentItems = new ObservableCollection<ParentItem>
            {
                new ParentItem
                {
                    Title = "Parent Item 1",
                    ChildItems = new ObservableCollection<string> { "Child 1", "Child 2", "Child 3", "Child 4", "Child 5", "Child 6", "Child 7", "Child 8", "Child 9", "Child 10", }
                },
                new ParentItem
                {
                    Title = "Parent Item 2",
                    ChildItems = new ObservableCollection<string> { "Child A", "Child B", "Child C" }
                },
                new ParentItem
                {
                    Title = "Parent Item 3",
                    ChildItems = new ObservableCollection<string> { "Child X", "Child Y", "Child Z" }
                },
                new ParentItem
                {
                    Title = "Parent Item 4",
                    ChildItems = new ObservableCollection<string> { "Child 1", "Child 2", "Child 3", "Child 4", "Child 5", "Child 6", "Child 7", "Child 8", "Child 9", "Child 10", }
                },
                new ParentItem
                {
                    Title = "Parent Item 5",
                    ChildItems = new ObservableCollection<string> { "Child 1", "Child 2", "Child 3", "Child 4", "Child 5", "Child 6", "Child 7", "Child 8", "Child 9", "Child 10", }
                },
                new ParentItem
                {
                    Title = "Parent Item 6",
                    ChildItems = new ObservableCollection<string> { "Child 1", "Child 2", "Child 3", "Child 4", "Child 5", "Child 6", "Child 7", "Child 8", "Child 9", "Child 10", }
                },
                new ParentItem
                {
                    Title = "Parent Item 7",
                    ChildItems = new ObservableCollection<string> { "Child 1", "Child 2", "Child 3", "Child 4", "Child 5", "Child 6", "Child 7", "Child 8", "Child 9", "Child 10", }
                },
                new ParentItem
                {
                    Title = "Parent Item 8",
                    ChildItems = new ObservableCollection<string> { "Child 1", "Child 2", "Child 3", "Child 4", "Child 5", "Child 6", "Child 7", "Child 8", "Child 9", "Child 10", }
                },
                new ParentItem
                {
                    Title = "Parent Item 9",
                    ChildItems = new ObservableCollection<string> { "Child 1", "Child 2", "Child 3", "Child 4", "Child 5", "Child 6", "Child 7", "Child 8", "Child 9", "Child 10", }
                },
            };
        }
    }

    public class ParentItem
    {
        public string Title { get; set; }
        public ObservableCollection<string> ChildItems { get; set; }
    }
}