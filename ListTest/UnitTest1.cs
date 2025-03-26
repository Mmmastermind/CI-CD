using ListLibrary;

namespace ListTest
{
    public class UnitTest1
    {
        [Fact]
        public void Add_ValidInput_AddsItemToList()
        {
            var list = new List<int> { 1, 2, 3 };
            int item = 4;

            ListUtils.Add(list, item);

            Assert.Contains(item, list);
        }

        [Fact]
        public void Add_NullList_ThrowsArgumentNullException()
        {
          
            List<int> list = null;
            int item = 1;

            Assert.Throws<ArgumentNullException>(() => ListUtils.Add(list, item));
        }

        [Fact]
        public void Remove_ExistingItem_RemovesItemFromList()
        {
            var list = new List<int> { 1, 2, 3 };
            int item = 2;

            ListUtils.Remove(list, item);

            Assert.DoesNotContain(item, list);
        }

        [Fact]
        public void Remove_NullList_ThrowsArgumentNullException()
        {
            List<int> list = null;
            int item = 1;

            Assert.Throws<ArgumentNullException>(() => ListUtils.Remove(list, item));
        }

        [Fact]
        public void Remove_InvalidItem_ArgumentException()
        {
            var list = new List<int> { 4, 2, 3 };
            int item = 15;

            Assert.Throws<ArgumentException>(() => ListUtils.Remove(list, item));
        }

        [Fact]
        public void Contains_ExistingItem_ReturnsTrue()
        {
           
            var list = new List<int> { 1, 2, 3 };
            int item = 2;

            
            var result = ListUtils.Contains(list, item);

            
            Assert.True(result);
        }

        [Fact]
        public void Contains_NullList_ThrowsArgumentNullException()
        {
            
            List<int> list = null;
            int item = 1;

            
            Assert.Throws<ArgumentNullException>(() => ListUtils.Contains(list, item));
        }
        [Fact]
        public void Contains_InvalidItem_ArgumentException()
        {

            var list = new List<int> { 1, 2, 3 };
            int item = 5;


            Assert.Throws<ArgumentException>(() => ListUtils.Contains(list, item));
        }
    }
}