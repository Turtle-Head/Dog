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
            Animal[] Kingdom = new Animal[4];
            Kingdom[0] = new Dog("Jeff", 2, "Labrador retriever", "Dog", "happy");
            Kingdom[1] = new Cat("Patty", 3, "Manx", "Cat", "happy");
            Kingdom[2] = new Dog("Randal", 10000, "Doberman", "Dog", "ornery");
            Kingdom[3] = new Cat("Thomas O'malley", 8, "Tabby", "Cat", "bored");
            Kingdom[2].Name = "Mr.T";
            Kingdom[2].Age = -999999;
            Kingdom[2].Breed = "Rotweiler";

            for (int i = 0; i < 4; i++)
            {
                if (Kingdom[i].Species == "Dog")
                {
                    output.Text += "\n";
                    output.Text += $"{Kingdom[i].Name} is a {Kingdom[i].Mood} {Kingdom[i].Age} year old {Kingdom[i].Breed} \n";
                    output.Text += Kingdom[i].Bark();
                    output.Text += Kingdom[i].WagTail();
                    output.Text += Kingdom[i].Eating();
                    output.Text += Kingdom[i].Sleeping;
                }
                else if (Kingdom[i].Species == "Cat")
                {
                    output.Text += "\n";
                    output.Text += $"{Kingdom[i].Name} is a {Kingdom[i].Mood} {Kingdom[i].Age} year old {Kingdom[i].Breed} \n";
                    output.Text += Kingdom[i].Meow();
                    output.Text += Kingdom[i].Purr();
                    output.Text += Kingdom[i].Eating();
                    output.Text += Kingdom[i].Sleeping;
                }
            }




        }



    }
}