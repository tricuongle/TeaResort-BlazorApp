﻿using Newtonsoft.Json;


namespace SmartRetail.Share.Models
{
    public class SectionModel : BaseNotifyModel
    {
        #region private varian

        int _Id;
        string _Name;
        int _Location;
        string _Description;
        string _Icon;
        #endregion
        public SectionModel()
        {
        }
        [JsonProperty]
        public int Id
        {
            get { return _Id; }
            set { SetProperty(ref _Id, value); }
        }
        [JsonProperty]
        public string Name
        {
            get { return _Name; }
            set { SetProperty(ref _Name, value); }
        }
        [JsonProperty]
        public int Zone
        {
            get { return _Location; }
            set { SetProperty(ref _Location, value); }
        }
        [JsonProperty]
        public string Description
        {
            get { return _Description; }
            set { SetProperty(ref _Description, value); }
        }
        [JsonProperty]
        public string Icon
        {
            get { return _Icon; }
            set { SetProperty(ref _Icon, value); }
        }
    }
}
