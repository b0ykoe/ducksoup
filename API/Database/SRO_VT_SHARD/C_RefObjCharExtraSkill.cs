using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Database.SRO_VT_SHARD
{
    [Table("_RefObjCharExtraSkill")]
    public partial class C_RefObjCharExtraSkill
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CharID { get; set; }

        public int? ExtraSkill_1 { get; set; }

        public int? ExtraSkill_2 { get; set; }

        public int? ExtraSkill_3 { get; set; }

        public int? ExtraSkill_4 { get; set; }

        public int? ExtraSkill_5 { get; set; }

        public int? ExtraSkill_6 { get; set; }

        public int? ExtraSkill_7 { get; set; }

        public int? ExtraSkill_8 { get; set; }

        public int? ExtraSkill_9 { get; set; }

        public int? ExtraSkill_10 { get; set; }

        public int? ExtraSkill_11 { get; set; }

        public int? ExtraSkill_12 { get; set; }

        public int? ExtraSkill_13 { get; set; }

        public int? ExtraSkill_14 { get; set; }

        public int? ExtraSkill_15 { get; set; }

        public int? ExtraSkill_16 { get; set; }

        public int? ExtraSkill_17 { get; set; }

        public int? ExtraSkill_18 { get; set; }

        public int? ExtraSkill_19 { get; set; }

        public int? ExtraSkill_20 { get; set; }
    }
}
