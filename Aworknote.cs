using System;
using System.Drawing;

[Serializable]
public class Aworknote
{
    private Color color;
    private string title;
    private string description;
    private DateTime created;
    private DateTime deadline;

    public Aworknote(Color aColor, string aTitle, string aDescription, DateTime aCreated, DateTime aDeadline)
    {
        color = aColor;
        title = aTitle;
        description = aDescription;
        created = aCreated;
        deadline = aDeadline;
    }

    public Color Color { get => color; private set => color = value; }
    public string Title { get => title; private set => title = value; }
    public string Description { get => description; private set => description = value; }
    public DateTime Created { get => created; private set => created = value; }
    public DateTime Deadline { get => deadline; private set => deadline = value; }
}