

namespace LibraryCard
{
    class Telephone
    {

        #region [Properties]
        /// <summary>
        /// شماره تلفن
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// نوع تلفن
        /// </summary>
        public TelephonType TelephonType { get; set; }
        #endregion

        #region [Constructor]
        public Telephone()
        {

        }

        public Telephone(string number, TelephonType telephonType)
        {
            Number = number;
            TelephonType = telephonType;
        }
        #endregion

        #region [Method]
        public override string ToString()
        {
            return $" Number : {Number}\t\t TelephoneType : {TelephonType}\t\t ";
        } 
        #endregion
    }
}
