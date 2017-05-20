using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library264
{
    public enum CustormerType
    {
        Common = 6, Stundent, Child, Old
    }
    public enum Degree
    {
        高中 = 1, 中专, 大专 = 11, 本科, 硕士, 博士
    }
    public enum StaffState
    {
        在岗, 试用, 随团, 出差, 休假, 离职, Undefined
    }
    public enum TourState
    {
        报名, 满员, 发团, 完成, 取消, Undefined
    }
    public enum Area
    {
        华北, 东北, 华东, 中南, 西南, Undefined
    }
    public enum SceneType
    {
        自然山水, 海滨沙滩, 草原沙漠, 公园博物馆, 名胜古迹
    }
}
