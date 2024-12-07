using System.Collections.ObjectModel;

namespace CollectionViewScrollIssue
{
    public class MainViewModel
    {
        public ObservableCollection<CollectionViewItem> ParentItems { get; set; }

        public MainViewModel()
        {
            ParentItems = new ObservableCollection<CollectionViewItem>
            {
                new CollectionViewItem
                {
                    Title = "Inner CollectionView 1",
                    ChildItems = new ObservableCollection<string> { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6", "Item 7", "Item 8", "Item 9", "Item 10", }
                },
                new CollectionViewItem
                {
                    Title = "Inner CollectionView 2",
                    ChildItems = new ObservableCollection<string> { "Item A", "Item B", "Item C" }
                },
                new CollectionViewItem
                {
                    Title = "Inner CollectionView 3",
                    ChildItems = new ObservableCollection<string> { "Item X", "Item Y", "Item Z" }
                },
                new CollectionViewItem
                {
                    Title = "Inner CollectionView 4",
                    ChildItems = new ObservableCollection<string> { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6", "Item 7", "Item 8", "Item 9", "Item 10", }
                },
                new CollectionViewItem
                {
                    Title = "Inner CollectionView 5",
                    ChildItems = new ObservableCollection<string> { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6", "Item 7", "Item 8", "Item 9", "Item 10", }
                },
                new CollectionViewItem
                {
                    Title = "Inner CollectionView 6",
                    ChildItems = new ObservableCollection<string> { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6", "Item 7", "Item 8", "Item 9", "Item 10", }
                },
                new CollectionViewItem
                {
                    Title = "Inner CollectionView 7",
                    ChildItems = new ObservableCollection<string> { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6", "Item 7", "Item 8", "Item 9", "Item 10", }
                },
                new CollectionViewItem
                {
                    Title = "Inner CollectionView 8",
                    ChildItems = new ObservableCollection<string> { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6", "Item 7", "Item 8", "Item 9", "Item 10", }
                },
                new CollectionViewItem
                {
                    Title = "Inner CollectionView 9",
                    ChildItems = new ObservableCollection<string> { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6", "Item 7", "Item 8", "Item 9", "Item 10", }
                },
            };
        }
    }

    public class CollectionViewItem
    {
        public string Title { get; set; }
        public ObservableCollection<string> ChildItems { get; set; }
    }
}
