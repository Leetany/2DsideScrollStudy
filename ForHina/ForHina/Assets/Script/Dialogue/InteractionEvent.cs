using UnityEngine;

public class InteractionEvent : MonoBehaviour
{

    [SerializeField] private DialogueEvent dialogue;
    private DialogueManager DM;

    public Dialogue[] GetDialogues()
    {
        dialogue.dialogues = DatabaseManager.instance.GetDialogue((int)dialogue.line.x, (int)dialogue.line.y);
        return dialogue.dialogues;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            DialogueManager.instance.ShowDialogue(GetDialogues());
            gameObject.SetActive(false);
        }
    }

}