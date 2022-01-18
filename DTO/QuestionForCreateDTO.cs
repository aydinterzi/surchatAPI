using System.Collections.Generic;

namespace surchatAPI.DTO
{
    public class QuestionForCreateDTO
    {
        public string Question { get; set; }
        public List<OptionForCreateDTO> Options { get; set; }
        public int Code { get; set; }
    }
}
