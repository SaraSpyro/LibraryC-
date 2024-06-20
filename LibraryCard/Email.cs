

namespace LibraryCard
{
    class Email
    {

        #region [Properties]
        /// <summary>
        /// نام و عنوان ایمیل
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// ارائه دهندگان ایمیل
        /// </summary>
        public EmailProviders EmailProviders { get; set; }
        #endregion

        #region [Constructor]
        public Email()
        {

        }

        public Email(string title, EmailProviders emailProviders)
        {
            Title = title;
            EmailProviders = emailProviders;
        }
        #endregion

        #region [Method]
        public override string ToString()
        {
            return $" Title : {Title}\t\t EmailProviders : {EmailProviders}\t\t";
        } 
        #endregion
    }
}
