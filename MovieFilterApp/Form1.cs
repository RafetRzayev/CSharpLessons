namespace MovieFilterApp
{
    public partial class Form1 : Form
    {
        private List<Movie> _movies = new List<Movie>();
        private List<Button> _boxes = new List<Button>();

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            cmbGenres.Items.Add("All");

            foreach (GenreType genre in Enum.GetValues(typeof(GenreType)))
            {
                cmbGenres.Items.Add(genre);
            }

            cmbGenres.SelectedIndex = 0;

            SeedData();

            GenerateMovieBoxes();
        }

        private void GenerateMovieBoxes()
        {
            for (int i = 0; i < _movies.Count; i++)
            {
                _boxes.Add(new Button()
                {
                    Text = _movies[i].Name,
                    BackColor = ConvertGenreToColor(_movies[i].Genre),
                    Height = 100,
                    Width = 200,
                    Top = 100,
                    Left = 100 + i * 200
                });
            }

            this.Controls.AddRange(_boxes.ToArray());
        }

        private void SeedData()
        {
            _movies.Add(new("Seven", GenreType.Dram));
            _movies.Add(new("Friends", GenreType.Comedy));
            _movies.Add(new("Imposible", GenreType.Action));
            _movies.Add(new("Red door", GenreType.Action));
        }

        private Color ConvertGenreToColor(GenreType genre)
        {
            switch (genre)
            {
                case GenreType.Comedy:
                    return Color.Yellow;
                case GenreType.Dram:
                    return Color.Red;
                case GenreType.Action:
                    return Color.Salmon;
                default:
                    return Color.Black;
            }
        }

        private void cmbGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGenres.SelectedIndex == 0)
            {
                foreach (var box in _boxes)
                {
                    box.Visible = true;
                }

                return;
            }

            GenreType genre = (GenreType)cmbGenres.SelectedItem;

            for (int i = 0; i < _movies.Count; i++)
            {
                if (_movies[i].Genre != genre)
                    _boxes[i].Visible = false;
                else
                    _boxes[i].Visible = true;
            }
        }
    }

    enum GenreType
    {
        Comedy,
        Dram,
        Action
    }

    class Movie
    {
        public Movie(string name, GenreType genre)
        {
            Name = name;
            Genre = genre;
        }

        public string Name { get; set; }
        public GenreType Genre { get; set; }
    }
}
