using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class HigherLowerGameLogic
    {
        private readonly Dictionary<IFacebookObjectAdapter, long> r_ItemsWithValues = new Dictionary<IFacebookObjectAdapter, long>();
        private IFacebookObjectAdapter m_currentItem;
        private IFacebookObjectAdapter m_nextItem;
        private Random r_random = SingletonRandomizer.Instance;
        public event Action GameObjectWithDefaultValueDetected;

        public int Score { get; private set; } = 0;                                                                  
        public bool GameIsRunning{ get; private set; } = false;                                                      
        public int MaxScore { get; private set; } = 0;                                                               
        public IFacebookObjectAdapter CurrentItem                                                                            
        {                                                                                                            
            get { return m_currentItem; }                                                                            
        }                                                                                                            
        public IFacebookObjectAdapter NextItem                                                                               
        {                                                                                                            
            get { return m_nextItem; }                                                                               
        }                                                                                                            
        public long CurrentItemValue                                                                                 
        {                                                                                                            
            get { return r_ItemsWithValues[m_currentItem]; }                                                         
        }    
        
        public IFacebookObjectAdapter GetRandomItem()                                                                        
        {                                                                                                            
            int randomIndex = r_random.Next(r_ItemsWithValues.Count);                                                
                                                                                                                     
            return r_ItemsWithValues.ElementAt(randomIndex).Key;                                                     
        }                                                                                                            
                                                                                                                     
        public void SetupNewGame(List<IFacebookObjectAdapter> i_facebookObjects)                                             
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
            makeGuess(() => r_ItemsWithValues[m_currentItem] >= r_ItemsWithValues[m_nextItem]);
        }                                                                                                            
                                                                                                                     
        public void MakeGuessCurrentIsLower()                                                                        
        {
            makeGuess(() => r_ItemsWithValues[m_currentItem] <= r_ItemsWithValues[m_nextItem]);                                  
        }
        
        private void makeGuess(Func<bool> i_Strategy)
        {
            if (i_Strategy.Invoke())
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
                                                                                                                     
        private void addFacebookObjectsForComparison(List<IFacebookObjectAdapter> i_facebookObjects)                         
        {
            bool gameObjectWithDefaultValueDetectedYet = false;
            foreach (IFacebookObjectAdapter facebookObject in i_facebookObjects)                                             
            {                                                                                                        
                try                                                                                                  
                {     
                    r_ItemsWithValues.Add(facebookObject, facebookObject.LikesCount);    
                    if(facebookObject.HasDefaultValue && !gameObjectWithDefaultValueDetectedYet)
                    {
                        gameObjectWithDefaultValueDetectedYet = true;
                        GameObjectWithDefaultValueDetected.Invoke();
                    }
                }                                                                                                    
                catch (Exception)                                                                                    
                {                                                                                                    
                }                                                                                                    
            }                                                                                                        
        }                                                                                                            
                                                                                                                     
        public void SetupNewGameWithDummyValues(List<IFacebookObjectAdapter> i_facebookObjects)                              
        {                                                                                                            
            foreach (IFacebookObjectAdapter facebookObject in i_facebookObjects)                                             
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
                                                                                                                     