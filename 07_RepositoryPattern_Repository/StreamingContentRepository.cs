using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository //used with interacting with data
{
    public class StreamingContentRepository //create repository for SteamingContent
    {
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();
        //CRUD Create Read Update Delete
        //Create
        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _contentDirectory.Count;
            _contentDirectory.Add(content);
            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }
        //READ ALL
        public List<StreamingContent> GetContents()
        {
            return _contentDirectory;
        }
        //READ ONE of the ojects
        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent singleContent in _contentDirectory)
            {
                if (singleContent.Title.ToLower() == title.ToLower())
                {
                    return singleContent;
                }
            }
            return null;
        }
        //UPDATE 
        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);
            if(oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.StarRating = newContent.StarRating;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.IsFamilyFriendly = newContent.IsFamilyFriendly;
                oldContent.TypeOfGenre = newContent.TypeOfGenre;

                return true;
            }
            else
            {
                return false;
            }
        }
        
        //Delete
        public bool DeleteExistingContent(StreamingContent existingContent)
        {
            bool deleteResults = _contentDirectory.Remove(existingContent);
            return deleteResults;
        }
    }
}
