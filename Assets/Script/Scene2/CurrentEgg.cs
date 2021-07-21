using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentEgg : MonoBehaviour
{
    public UI uI;
    public StarGazer starGazer;
    public StarManager starManager;

    //text
    public Text mainText;
    public Text title;
    public int show_text_index;

    void Start()
    {
        show_text_index = 0;
    }

    void Update()
    {
        SpriteShow(show_text_index);
    }

    public void TextShow(int index) {
        if (index == 1) {
            title.text = "星星";
            mainText.text = "\n\n\n看，好多星星！\n这是属于你的第二片星空\n和那个球不一样\n这个会不断有新的星星出现\n\n继续探索试试看\n一次性究竟能看到多少星星呢";
        }
        if (index == 2) {
            title.text = "煤球";
            mainText.text = "\n\n\n我说咋找不到她了\n原来在宇宙里探险啊\n这就把她抱走，您继续\n\n还记得她缩在衣柜里躲你么\n什么时候再来看看她吧\n\n在星空里按下Tab可以回到这里";
        }
        if (index == 3) {
            title.text = "海胆饭";
            mainText.text = "\n\n\n我爱海胆饭\n特别是和你一起恰的海胆饭\n\n道格拉斯亚当斯说\n宇宙尽头的餐厅里什么都有\n这碗会不会是从那里掉出来的";
        }
        if (index == 4) {
            title.text = "街灯";
            mainText.text = "\n\n\n晚上在散步的时候最喜欢街灯\n光让鬼怪和女巫都不敢睁眼\n好让我瞧瞧多看一眼你的眼睛\n比宇宙还美的眼睛\n\n晚上在散步的时候最讨厌街灯\n蚊子好多";
        }
        if (index == 5) {
            title.text = "草莓牛奶";
            mainText.text = "\n\n\n我小时候不喜欢纯牛奶\n所以喜欢在牛奶里加东西\n\n加了咖啡的奶冲淡了苦涩化了糖\n加了抹茶的奶是四季不变的清香\n加了草莓的奶有一点点酸酸甜甜\n都是喜欢你的味道\n\n去找更多的星星吧！";
        }
        if (index == 6) {
            title.text = "夏公主";
            mainText.text = "\n\n\n有天晚上夏公主帮朋友拿着气球\n她心情很好在和音符跳舞\n我木纳呆在那里不知道该做什么\n\n如果头上没有屋顶\n她会不会飞到天上\n这样我抬头就会看见\n她与月亮，气球，音符\n还有我藏不住的喜欢\n一起跳舞";
        }
        if (index == 7) {
            title.text = "电影节";
            mainText.text = "当灯光暗下\n就会出现另一个世界\n像是黄昏下的海浪\n泳池前的镜子\n那里有俄罗斯的大雪\n和西班牙的日出\n鱼鳞在羊群中散开\n与人们的故事一起消失\n\n这是看了9999颗星才会出现的贴纸\n我想再请你忽略吵闹的理性和担心\n抓住初夏的尾巴\n一起跳进水里\n答应我吧 好不好啦？";
        }
    }

    void SpriteShow(int index) {
        if (index == 1) {
            GetComponent<SpriteRenderer>().sprite = uI.eggs_collection[0].sprite;
            TextShow(index);
        }
        if (index == 2) {
            GetComponent<SpriteRenderer>().sprite = uI.eggs_collection[1].sprite;
            TextShow(index);
        }
        if (index == 3) {
            GetComponent<SpriteRenderer>().sprite = uI.eggs_collection[2].sprite;
            TextShow(index);
        }
        if (index == 4) {
            GetComponent<SpriteRenderer>().sprite = uI.eggs_collection[3].sprite;
            TextShow(index);
        }
        if (index == 5) {
            GetComponent<SpriteRenderer>().sprite = uI.eggs_collection[4].sprite;
            TextShow(index);
        }
        if (index == 6) {
            GetComponent<SpriteRenderer>().sprite = uI.eggs_collection[5].sprite;
            TextShow(index);
        }
        if (index == 7) {
            GetComponent<SpriteRenderer>().sprite = uI.eggs_collection[6].sprite;
            TextShow(index);
        }
    }
}
