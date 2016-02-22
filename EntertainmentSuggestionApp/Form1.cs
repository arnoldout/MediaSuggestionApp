using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntertainmentSuggestionApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dfdg();
        }
        public void dfdg()
        {
            string baseURI = "http://api.themoviedb.org/3";
            String srch = "/search/movie?";
            string apiKey = "api_key=c2dcd458445148b91ed151b2a41a3c22";

            string query = "query=The GodFather&";
            //converts query into usable string
            String s = Uri.EscapeUriString(query);

            String uri = baseURI + srch + query + apiKey;
            //string b = "http://api.themoviedb.org/3/movie/238?api_key=c2dcd458445148b91ed151b2a41a3c22";
            WebRequest wrGETURL = WebRequest.Create(uri);
            Stream objStream = wrGETURL.GetResponse().GetResponseStream();

            StreamReader objReader = new StreamReader(objStream);
            dynamic movie = JsonConvert.DeserializeObject(objReader.ReadToEnd());
            List<Movie> movies = new List<Movie>();
            foreach (dynamic results in movie.results)
            { 
                movies.Add(new Movie(Convert.ToInt32(results.id), Convert.ToString(results.backdrop_path), Convert.ToString(results.title), Convert.ToString(results.overview), Convert.ToString(results.release_date), Convert.ToString(results.vote_average)));
            }
        }
    }
}
