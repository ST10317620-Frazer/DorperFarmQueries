using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    public class Post
    {
        public int Id {get; set;}
        public string Content {get; set;}
        public int Likes {get; set; }

   public override string ToString()
        {
            return $"{Id}: {Likes} likes - {Content}";
        }
    }
}