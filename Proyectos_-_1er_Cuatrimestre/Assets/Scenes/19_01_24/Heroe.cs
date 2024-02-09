using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heroe : PersonajeBase
{
    protected Quest quest;

    public void setQuest(string _name, string _description, string _title)
    {
        quest.id = Random.Range (0, 50);
        quest.name = _name;
        quest.description = _description;
        quest.title = _title;
    }

    public Quest GetQuest()
    {
        return quest;
    }
}
