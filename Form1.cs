using DocumentFormat.OpenXml.Wordprocessing;


namespace DOG
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            Dog Jeff = new("Jeff", 5, "Labrador retriever");
            output.Text += $"{Jeff.Name} is a {Jeff.Age} year old {Jeff.Breed}\n";
            output.Text += Jeff.Bark();
            output.Text += Jeff.WagTail();
            Dog Randal = new Dog("Randal",1000,"Rotweiller");
            Randal.Name = "Ralph";
            Randal.Age = -999999;
            Randal.Breed = "Doberman";
            output.Text += $"{Randal.Name} is a {Randal.Age} year old {Randal.Breed}\n";
            output.Text += Randal.Bark();
            output.Text += Randal.WagTail();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



    }
}