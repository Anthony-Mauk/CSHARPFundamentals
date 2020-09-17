using System;
using System.Collections.Generic;
using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests
    {
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            //Triple A Paradigm - Arrange 
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();
            //ACT
            bool addResult = repository.AddContentToDirectory(content);
            //ASSERT - verify expected outcome
            Assert.IsTrue(addResult);
        }
        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection() //get directory
        {
            //Arrange
            StreamingContent newObject = new StreamingContent();
            StreamingContentRepository repo = new StreamingContentRepository();

            repo.AddContentToDirectory(newObject);

            //ACT
            List<StreamingContent> listOfContents = repo.GetContents();

            //ASSERT
            bool directoryHasContent = listOfContents.Contains(newObject);
            Assert.IsTrue(directoryHasContent);
        }
        //ARRANGE
        private StreamingContentRepository _repo;
        private StreamingContent _content;
        [TestInitialize]
        //method to fire before every test
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("Oceans 8", "do crime", 100, "I do not know", true, GenreType.Action);
            _repo.AddContentToDirectory(_content);
        }
        [TestMethod]
        public void GetByTitleShouldReturnCorrectContent ()
        {
            //Arrange - done
            //ACT
            StreamingContent searchResults = _repo.GetContentByTitle("Oceans 8");
            //ASSERT
            Assert.AreEqual(_content, searchResults);
        }
        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            //arrange
            StreamingContent updatedContent = new StreamingContent("Italian Job", "do crime", 100, "I do not know", true, GenreType.Action);
            //ACT
            bool updateResults = _repo.UpdateExistingContent("Oceans 8", updatedContent);
            //ASSERT
            Assert.IsTrue(updateResults);
        }
        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            //Get content with ARRANGE

            StreamingContent foundContent = _repo.GetContentByTitle("Oceans 8");
            //ACT - ask to remove
            bool removeResult = _repo.DeleteExistingContent(foundContent);
            //ASSERT - did it work?
            Assert.IsTrue(removeResult);
        }
    }
}
