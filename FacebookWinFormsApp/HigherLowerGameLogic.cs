using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class HigherLowerGameLogic
    {
        private readonly Dictionary<FacebookObject, long> r_ItemsWithValues = new Dictionary<FacebookObject, long>();
        public int Score { get; private set; } = 0;                                                                  
        public bool GameIsRunning{ get; private set; } = false;                                                      
        public int MaxScore { get; private set; } = 0;                                                               
        public FacebookObject CurrentItem                                                                            
        {                                                                                                            
            get { return m_currentItem; }                                                                            
        }                                                                                                            
        public FacebookObject NextItem                                                                               
        {                                                                                                            
            get { return m_nextItem; }                                                                               
        }                                                                                                            
        public long CurrentItemValue                                                                                 
        {                                                                                                            
            get { return r_ItemsWithValues[m_currentItem]; }                                                         
        }                                                                                                            
                                                                                                                     
        private FacebookObject m_currentItem;                                                                        
        private FacebookObject m_nextItem;                                                                           
        private Random r_random = new Random();                                                                      
                                                                                                                     
        public FacebookObject GetRandomItem()                                                                        
        {                                                                                                            
            int randomIndex = r_random.Next(r_ItemsWithValues.Count);                                                
                                                                                                                     
            return r_ItemsWithValues.ElementAt(randomIndex).Key;                                                     
        }                                                                                                            
                                                                                                                     
        public void SetupNewGame(List<FacebookObject> i_facebookObjects)                                             
        {                                                                                                            
            addFacebookObjectsForComparison(i_facebookObjects);                                                      
            if (r_ItemsWithValues.Count < 2)                                                                         
            {                                                                                                        
                throw new Exception("Not enough items to play (need at least 2)");                                   
            }                                                                                                        
                                                                                                                     
            m_currentItem = GetRandomItem();                                                                         
            m_nextItem = GetRandomItem();                                                                            
            while (m_nextItem == m_currentItem)                                                                      
            {                                                                                                        
                m_nextItem = GetRandomItem();                                                                        
            }                                                                                                        
                                                                                                                     
            GameIsRunning = true;                                                                                    
            Score = 0;                                                                                               
        }                                                                                                            
                                                                                                                     
        public void MakeGuessCurrentIsHigher()                                                                       
        {                                                                                                            
            if (r_ItemsWithValues[m_currentItem] >= r_ItemsWithValues[m_nextItem])                                   
            {                                                                                                        
                Score++;                                                                                             
                generateNextItem();                                                                                  
            }                                                                                                        
            else                                                                                                     
            {                                                                                                        
                GameIsRunning = false;                                                                               
                tryUpdatingMaxScore();                                                                               
            }                                                                                                        
        }                                                                                                            
                                                                                                                     
        public void MakeGuessCurrentIsLower()                                                                        
        {                                                                                                            
            if (r_ItemsWithValues[m_currentItem] <= r_ItemsWithValues[m_nextItem])                                   
            {                                                                                                        
                Score++;                                                                                             
                generateNextItem();                                                                                  
            }                                                                                                        
            else                                                                                                     
            {                                                                                                        
                GameIsRunning = false;                                                                               
                tryUpdatingMaxScore();                                                                               
            }                                                                                                        
        }                                                                                                            
                                                                                                                     
        private void tryUpdatingMaxScore()                                                                           
        {                                                                                                            
            MaxScore = Math.Max(MaxScore, Score);                                                                    
        }                                                                                                            
                                                                                                                     
        private void generateNextItem()                                                                              
        {                                                                                                            
            m_currentItem = m_nextItem;                                                                              
            m_nextItem = GetRandomItem();                                                                            
            while (m_nextItem == m_currentItem)                                                                      
            {                                                                                                        
                m_nextItem = GetRandomItem();                                                                        
            }                                                                                                        
        }                                                                                                            
                                                                                                                     
        private void addFacebookObjectsForComparison(List<FacebookObject> i_facebookObjects)                         
        {                                                                                                            
            foreach (FacebookObject facebookObject in i_facebookObjects)                                             
            {                                                                                                        
                try                                                                                                  
                {                                                                                                    
                    if (facebookObject is Group group)                                                               
                    {                                                                                                
                        r_ItemsWithValues.Add(group, group.Members.Count);                                           
                    }                                                                                                
                    else if (facebookObject is Post post)                                                            
                    {                                                                                                
                        r_ItemsWithValues.Add(post, post.LikedBy.Count);                                             
                    }                                                                                                
                }                                                                                                    
                catch (Exception)                                                                                    
                {                                                                                                    
                }                                                                                                    
            }                                                                                                        
        }                                                                                                            
                                                                                                                     
        public void SetupNewGameWithDummyValues(List<FacebookObject> i_facebookObjects)                              
        {                                                                                                            
            foreach (FacebookObject facebookObject in i_facebookObjects)                                             
            {                                                                                                        
                r_ItemsWithValues.Add(facebookObject, r_random.Next(1, 1000));                                       
            }                                                                                                        
                                                                                                                     
            if (r_ItemsWithValues.Count < 2)                                                                         
            {                                                                                                        
                throw new Exception("Not enough items to play (need at least 2)");                                   
            }                                                                                                        
                                                                                                                     
            m_currentItem = GetRandomItem();                                                                         
            m_nextItem = GetRandomItem();                                                                            
            while (m_nextItem == m_currentItem)                                                                      
            {                                                                                                        
                m_nextItem = GetRandomItem();                                                                        
            }                                                                                                        
                                                                                                                     
            GameIsRunning = true;                                                                                    
            Score = 0;                                                                                               
        }                                                                                                            
    }                                                                                                                
}                                                                                                                    
                                                                                                                     