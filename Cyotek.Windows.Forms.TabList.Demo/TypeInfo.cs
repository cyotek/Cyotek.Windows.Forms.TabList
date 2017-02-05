namespace Cyotek.Windows.Forms.Demo
{
  internal class TypeInfo
  {
    #region Properties

    public string FullName { get; set; }

    public string Name { get; set; }

    #endregion

    #region Methods

    public override string ToString()
    {
      return this.Name;
    }

    #endregion
  }
}
