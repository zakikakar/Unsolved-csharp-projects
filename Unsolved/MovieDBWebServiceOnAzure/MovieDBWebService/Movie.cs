namespace MovieDBWebService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Movie")]
    public partial class Movie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public int Year { get; set; }

        public int RunningTimeInMins { get; set; }

        public int StudioId { get; set; }

        public override string ToString()
        {
            return $"{Title.TrimEnd(' ')}, made in {Year} ({RunningTimeInMins} mins.)";
        }
    }
}
