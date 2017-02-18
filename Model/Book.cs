//####################################### begin 郭林东 ##############################################
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Book
    {
        private string id;

        private string name;
        private string author;
        private string publisher;

        private string pubtime;
        private string pritime;

        private string edition;
        private string impression;

        private string pages;
        private string words;
       
        private string format;
        private string paper; 
        private string packaging;

        private string isbn;
        private byte[] picture;
        private string price;
        private string sort;
        private string inventory;



        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }
       

        public string Pubtime
        {
            get { return pubtime; }
            set { pubtime = value; }
        }
        

        public string Edition
        {
            get { return edition; }
            set { edition = value; }
        }
        

        public string Pages
        {
            get { return pages; }
            set { pages = value; }
        }
        

        public string Words
        {
            get { return words; }
            set { words = value; }
        }
        

        public string Pritime
        {
            get { return pritime; }
            set { pritime = value; }
        }
        

        public string Format
        {
            get { return format; }
            set { format = value; }
        }
        

        public string Paper
        {
            get { return paper; }
            set { paper = value; }
        }
       

        public string Impression
        {
            get { return impression; }
            set { impression = value; }
        }
        

        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }
        

        public string Packaging
        {
            get { return packaging; }
            set { packaging = value; }
        }

        public byte[] Picture
        {
            get { return picture; }
            set { picture = value; }
        }

        public string Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Sort
        {
            get { return sort; }
            set { sort = value; }
        }

        public string Inventory
        {
            get { return inventory; }
            set { inventory = value; }
        }
     
    }
}
//####################################### end 郭林东 ##############################################