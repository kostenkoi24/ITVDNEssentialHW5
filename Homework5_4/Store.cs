using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5_4
{
    class Store
    {

        Article[] articles = new Article[3];

        public Store(Article a, Article b, Article c)
        {
            this.articles[0] = a;
            this.articles[1] = b;
            this.articles[2] = c;
        }

        public Article this[int index]
        {
            get
            {
                if (index >= 0 && index < articles.Length)
                {
                    return articles[index];
                }
                else
                {
                    Console.WriteLine($"Max index {articles.Length}");
                    return articles[^1];
                }
                
            }
            set
            {
                articles[index] = value;
            }
        }

    }
}
