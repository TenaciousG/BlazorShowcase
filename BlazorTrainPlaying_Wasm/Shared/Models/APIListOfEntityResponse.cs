using System.Collections.Generic;

namespace BlazorTrainPlaying_Wasm.Shared.Models
{
    public class APIListOfEntityResponse<TEntity> where TEntity : class
    {
        public bool Success { get; set; }
        public List<string> ErrorMessages { get; set; } = new List<string>();
        public IEnumerable<TEntity> Data { get; set; }
    }
}