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
            Dog Randal = new("Randal",90,"Rotweiller");
            output.Text += $"{Randal.Name} is a {Randal.Age} year old {Randal.Breed}\n";
            output.Text += Randal.Bark();
            output.Text += Randal.WagTail();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



    }
}