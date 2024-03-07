using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPostagens.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Titulo { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();


        public Post() { }

        public Post(DateTime moment, string titulo, string content, int likes)
        {
            Moment = moment;
            Titulo = titulo;
            Content = content;
            Likes = likes;
        }



        public void AddComment(Comentario comment)
        {
            Comentarios.Add(comment);
        }

        public void RemoveComment(Comentario comment)
        {
            Comentarios.Remove(comment);
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Titulo);
            sb.Append(Likes);
            sb.Append("Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comentarios: ");
            foreach (Comentario c in Comentarios)
            {
                sb.AppendLine(c.Texto);
            }
            return sb.ToString();
        }
    }
}
