namespace Cyotek.Windows.Forms.Demo
{
  internal class TypeInfo
  {
    #region Overridden Members

    public override string ToString()
    {
      return this.Name;
    }

    #endregion

    #region Properties

    public string FullName { get; set; }

    public string Name { get; set; }

    #endregion
  }
}
