using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Threading;

namespace C18_Ex03_Logic
{
    public class CategoriesCounter
    {

        public List<CategoryItem> CategoryList { get; set; } = new List<CategoryItem>(6);

        public CategoriesCounter()
        {
            CategoryList.Add(new CategoryItem("Local Business or Place"));
            CategoryList.Add(new CategoryItem("Company,Organisation or Institution"));
            CategoryList.Add(new CategoryItem("Brand Or Product"));
            CategoryList.Add(new CategoryItem("Artist, Band, or Public Figure"));
            CategoryList.Add(new CategoryItem("Entertainment"));
            CategoryList.Add(new CategoryItem("Cause or community"));
        }


        public class CategoryItem
        {
            private string m_CategoryteStr;
            private static int m_Counter = 0;

            public CategoryItem(string i_categoryStr)
            {
                m_CategoryteStr = i_categoryStr;
            }

            public void incCounter()
            {
                m_Counter++;
            }

            public string Category
            {
                get
                {
                    return m_CategoryteStr;
                }
                private set { }

            }

            public int Counter
            {
                get
                {
                    return m_Counter;
                }
            }
        }
    }
}

