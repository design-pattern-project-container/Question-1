using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProject
{

    class AllSwimmers
    {
        //the listOfSwimmers is variable for list of all the swimmer objects that are going to be populated from the datasource in to the swimmer class 
        List<Swimmer> listOfSwimmers = new List<Swimmer>();
        //the data holder
        DataSource dataSource = new DataSource();

        //creating a clone function
        public AllSwimmers Clone()
        {
            return (AllSwimmers)this.MemberwiseClone();
        }
        public AllSwimmers()
        {
//iterate throught the datasource and create a A swimmer class and insert it into the list of swimmers 
            for (int i = 0; i < dataSource.lists.GetLength(0); i++)
            {


                string fullname = dataSource.lists[i, 0];
                string sex = dataSource.lists[i, 1];
                string age = dataSource.lists[i, 2];
                string time = dataSource.lists[i, 3];
                listOfSwimmers.Add(new Swimmer(fullname, sex, age, time));
            }
        }

        //the function will return the unordered original listOfSwimmer 
        public List<Swimmer> OriginalList()
        {
            return listOfSwimmers;
        }
        //return the ListofSwimmer in an order of Age
        public List<Swimmer> sortByAge()
        {
            Swimmer temp = listOfSwimmers[1];
            for (int j = 0; j < listOfSwimmers.LongCount(); j++)
            {
                for (int i = 0; i < listOfSwimmers.LongCount() - 1; i++)
                {
                    if (listOfSwimmers[i].age > listOfSwimmers[i + 1].age)
                    {
                        temp = listOfSwimmers[i + 1];

                        listOfSwimmers[i + 1] = listOfSwimmers[i];
                        listOfSwimmers[i] = temp;

                    }
                }
            }
            return listOfSwimmers;


        }
        //return the ListofSwimmer in an order of Time
        public List<Swimmer> sortByTime()
        {
            Swimmer temp = listOfSwimmers[1];
            for (int j = 0; j < listOfSwimmers.LongCount(); j++)
            {
                for (int i = 0; i < listOfSwimmers.LongCount() - 1; i++)
                {
                    if (listOfSwimmers[i].time > listOfSwimmers[i + 1].time)
                    {
                        temp = listOfSwimmers[i + 1];

                        listOfSwimmers[i + 1] = listOfSwimmers[i];
                        listOfSwimmers[i] = temp;

                    }
                }
            }
            return listOfSwimmers;


        }
        //return the ListofSwimmer in an order of sex
        public List<Swimmer> sortBySex()
        {
            listOfSwimmers.So rt();

            return listOfSwimmers;


        }
    }
}
