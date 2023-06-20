using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    [SerializeField] private SpriteRenderer dialogBox;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject ellipsis;
    [SerializeField] private GameObject pressEToTalkPrompt;

    private SpriteRenderer ellipsisSpriteRenderer;
    private SpriteRenderer pressEToTalkPromptSpriteRenderer;

    private Animator ellipsisAnimator;

    // Start
    private void Start()
    {
        ellipsisSpriteRenderer = ellipsis.GetComponent<SpriteRenderer>();
        ellipsisAnimator = ellipsis.GetComponent<Animator>();
        pressEToTalkPromptSpriteRenderer = pressEToTalkPrompt.GetComponent<SpriteRenderer>();

        ellipsisSpriteRenderer.enabled = false;
        ellipsisAnimator.enabled = false;
        pressEToTalkPromptSpriteRenderer.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Character")
        {
            //ellipsisSpriteRenderer.enabled = true;
            pressEToTalkPromptSpriteRenderer.enabled = true;

            UnityEngine.Debug.Log(collision.gameObject);

            pressEToTalkPrompt.GetComponent<Transform>().position = new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y + 2.1f);

            //ellipsisAnimator.enabled = true;
            //ellipsisAnimator.Play("Ellipsis", -1);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Character")
        {
            //ellipsisSpriteRenderer.enabled = false;
            pressEToTalkPromptSpriteRenderer.enabled = false;

            //ellipsisAnimator.enabled = false;
        }
    }
}
