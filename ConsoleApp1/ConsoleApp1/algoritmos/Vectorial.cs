using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.algoritmos
{
    class Vectorial
    {
        private Dictionary<string, Dictionary<string, Term>> dic_words = new Dictionary<string, Dictionary<string, Term>>();
        private Dictionary<string, double> word_yardstick = new Dictionary<string, double>();
        private Dictionary<string, Term> query_works = new Dictionary<string, Term>();
        private Dictionary<string, int> appearances = new Dictionary<string, int>();
        private double query_yardstick = 0;
        private int quantity_docs = 0;
        private Database indice = new Database();
        public Scale scale = new Scale();

        public Vectorial(Database d)
        {
            this.indice = d;
            this.Set_Docs();
        }

        public void Set_Docs()
        {
            this.Set_dic(indice.Get_dic_docs_word());

            this.Set_dic_appearances(indice.Get_dic_appearances_words());

            this.algorithm();
        }

        public void Compare_Query_Docs()
        {
            this.Set_dic_query(indice.Get_dic_query());

            this.Apply_algo_query();

            this.Make_Scale();
        }

        public void Set_quantity_docs()
        {
            this.quantity_docs = this.dic_words.Count;
        }

        public void Set_dic(Dictionary<string, Dictionary<string, Term>> dic)
        {
            this.dic_words = dic;
            this.Set_quantity_docs();
        }

        public void Set_dic_appearances(Dictionary<string, int> dic)
        {
            this.appearances = dic;
        }

        public void Set_dic_query(Dictionary<string, Term> dic)
        {
            this.query_works = dic;
        }

        public void algorithm()
        {
            foreach (var temp in this.dic_words.Keys)
            {
                double yardstick = 0;
                foreach (var word in this.dic_words[temp].Keys)
                {
                    if (this.dic_words[temp][word].Get_appearance() != 0)
                    {
                        this.dic_words[temp][word].Set_vectorial(this.Calculate_weigth(this.dic_words[temp][word]) * this.Calculate_N_ni(word));
                        yardstick += Math.Pow(this.dic_words[temp][word].Get_vectorial(),2);
                    }
                }
                yardstick = Math.Sqrt(yardstick);
                this.word_yardstick.Add(temp,yardstick);
                yardstick = 0;

                foreach (var word in this.dic_words[temp].Keys)
                {
                    if (this.dic_words[temp][word].Get_appearance() != 0)
                    {
                        this.dic_words[temp][word].Set_vectorial_weight(this.dic_words[temp][word].Get_vectorial()/this.word_yardstick[temp]);
                    }
                }
            }
        }

        public double Calculate_weigth(Term word)
        {
            double value = (double)1 + Math.Log(word.Get_appearance(), 2);
            return value;
        }

        public double Calculate_N_ni(string word)
        {            
            double num = (double)this.quantity_docs / (double)this.appearances[word];
            double value = Math.Log(num, 2);
            return value;
        }

        public void Apply_algo_query()
        {
            double yardstick = 0;
            foreach (var word in this.query_works.Keys)
            {
                if (this.query_works[word].Get_appearance() != 0)
                {
                    this.query_works[word].Set_vectorial(this.Calculate_weigth(this.query_works[word]) * this.Calculate_N_ni(word));
                    yardstick += Math.Pow(this.query_works[word].Get_vectorial(), 2);
                }
            }
            this.query_yardstick = Math.Sqrt(yardstick);
            yardstick = 0;

            foreach (var word in this.query_works.Keys)
            {
                if (this.query_works[word].Get_appearance() != 0)
                {
                    this.query_works[word].Set_vectorial_weight(this.query_works[word].Get_vectorial() / this.query_yardstick);
                }
            }
        }

        public void Make_Scale()
        {
            foreach (var doc in this.dic_words.Keys)
            {
                double value = 0;
                foreach (var work in this.query_works.Keys)
                {
                    if (this.query_works[work].Get_appearance() != 0)
                        value += this.query_works[work].Get_vectorial_normalize() * this.dic_words[doc][work].Get_vectorial_normalize();
                }
                this.scale.Add_scale(doc, value);
                value = 0;
            }
        }

        public void print()
        {
            foreach (var temp in this.dic_words.Keys)
            {
                Console.WriteLine(temp);
                foreach (var temp2 in this.dic_words[temp])
                {
                    if(temp2.Value.Get_vectorial() != 0)
                    {
                        Console.WriteLine(temp2.Key + "\t: " + temp2.Value.Get_vectorial() + "\t: " + temp2.Value.Get_vectorial_normalize());
                    }
                }
            }
        }

        public void print2()
        {
            foreach (var temp in this.word_yardstick.Keys)
            {
                Console.WriteLine(temp + "\t: " + this.word_yardstick[temp]);
            }
        }

        public void print3()
        {
            Console.WriteLine("query");
            foreach (var temp in this.query_works.Keys)
            {
                Console.WriteLine(temp + "\t: " + this.query_works[temp].Get_appearance() + "\t: " 
                    + this.query_works[temp].Get_vectorial() + "\t: " + this.query_works[temp].Get_vectorial_normalize());
            }
            Console.WriteLine(this.query_yardstick);
        }
    }
}
