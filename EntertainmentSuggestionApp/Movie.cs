using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentSuggestionApp
{
    class Movie
    {
        int id;
        String backdropPath;
        String title;
        String overview;
        String releaseDate;
        String voteAvg;

        public Movie(int id, string backdropPath, string title, string overview, string releaseDate, string voteAvg)
        {
            this.id = id;
            this.backdropPath = backdropPath;
            this.title = title;
            this.overview = overview;
            this.releaseDate = releaseDate;
            this.voteAvg = voteAvg;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string BackdropPath
        {
            get
            {
                return backdropPath;
            }

            set
            {
                backdropPath = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string Overview
        {
            get
            {
                return overview;
            }

            set
            {
                overview = value;
            }
        }

        public string ReleaseDate
        {
            get
            {
                return releaseDate;
            }

            set
            {
                releaseDate = value;
            }
        }

        public string VoteAvg
        {
            get
            {
                return voteAvg;
            }

            set
            {
                voteAvg = value;
            }
        }      
    }
}
