using System;
using System.Collections.Generic;
using System.Text;

namespace VideoImagePostProject
{
    class Post
    {
        private static int currentPostId;

        //properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        public bool IsPublic { get; set; }


        //Default constructor, if a derived class does not invoke a base-
        //class constructor explicitly, the default constructor is called
        //implicitly.

        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUsername = "Timi Adiel";

        }

        //Instance constructor that has three parameter
        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }

        //ID should not be zero instead it should be unique create a method
        protected int GetNextID()
        {
            return ++currentPostId;
        }

        //to edit the text in our post we create a method
        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        //vertual method override of 2 string inherited from system.object
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUsername);
        }
    }
}
