class File
{
    private string name;
    private int pages;

    public File(string name, int pages)
    {
        this.name = name;
        this.pages = pages;
    }

    public string GetName()
    {
        return name;
    }

    public int GetPages()
    {
        return pages;
    }
}