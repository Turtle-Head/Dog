using Amazon.CloudFormation.Model;
using DocumentFormat.OpenXml.Wordprocessing;
using System;


namespace DOG
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Animal [] Kingdom = new Animal[4];
            Kingdom[0] = new Dog("Jeff", 5, "Labrador retriever", "Dog", "happy");
            Kingdom[1] = new Dog("Randal", 1000, "Rotweiller", "Dog", "ornery");
            Kingdom[2] = new Cat("Patty", 5, "Manx", "Cat", "happy");
            Kingdom[3] = new Cat("Thomas O'malley", 2, "Tabby", "Cat", "bored");
            Kingdom[1].Name = "Ralph";
            Kingdom[1].Age = -999999;
            Kingdom[1].Breed = "Doberman";

            for (int i = 0; i < 4; i++) 
            {
                if (Kingdom[i].Species == "Dog")
                {
                    output.Text += $"{Kingdom[i].Name} is a {Kingdom[i].Mood} {Kingdom[i].Age} year old {Kingdom[i].Breed} \n";
                    output.Text += Kingdom[i].Bark();
                    output.Text += Kingdom[i].WagTail();
                    output.Text += Kingdom[i].Sleeping();
                    output.Text += Kingdom[i].Eating();
                } else if (Kingdom[i].Species == "Cat")
                {
                    output.Text += $"{Kingdom[i].Name} is a {Kingdom[i].Mood} {Kingdom[i].Age} year old {Kingdom[i].Breed} \n";
                    output.Text += Kingdom[i].Meow();
                    output.Text += Kingdom[i].Purr();
                    output.Text += Kingdom[i].Eating();
                    output.Text += Kingdom[i].Sleeping();
                }
            }
            
           
           
           
        }



    }
}