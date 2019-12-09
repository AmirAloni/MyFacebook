using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C18_Ex03_Logic
{
    public class MyPhotoList : IEnumerable, IEnumerable<Photo>
    {
        public List<Photo> TaggedPhotos { get; set; }

        public MyPhotoList()
        {
            TaggedPhotos = new List<Photo>();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new PhotosIterator(this);
        }


        IEnumerator<Photo> IEnumerable<Photo>.GetEnumerator()
        {
            for (int i = 0; i < TaggedPhotos.Count; ++i)
            {
                yield return TaggedPhotos[i];
            }
        }

        private class PhotosIterator : IEnumerator
        {
            private MyPhotoList m_Collection;
            private int m_CurrentIdx = -1;
            private int m_Count = -1;

            public PhotosIterator(MyPhotoList i_Collection)
            {
                m_Collection = i_Collection;
                m_Count = m_Collection.TaggedPhotos.Count;
            }

            public object Current
            {
                get
                {
                    return m_Collection.TaggedPhotos[m_CurrentIdx];
                }
            }

            public bool MoveNext()
            {
                ++m_CurrentIdx;
                return m_CurrentIdx < m_Collection.TaggedPhotos.Count;
            }

            public void Reset()
            {
                m_CurrentIdx = 0;
            }
        }
    }
}
