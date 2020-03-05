namespace XamarinListView
{
    public class Clube
    {
        public string Nome { get; set; }
        public string Divisao { get; set; }
        public string ImageUrl { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
