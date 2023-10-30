using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scorpio.Tang.Core.State.Character
{
    public partial class CharacterState
    {
        /// <summary>
        /// 所属玩家Id
        /// </summary>
        public virtual long UserId { get; set; }

        /// <summary>
        /// 玩家角色编号
        /// </summary>
        public virtual long CharacterId { get; set; }

        /// <summary>
        /// 所属服务器Id
        /// </summary>
        public virtual int ServerId { get; set; }

        /// <summary>
        ///  角色名称
        /// </summary>
        public virtual string Name { get; set; } = string.Empty;

        /// <summary>
        /// 角色性别
        /// </summary>
        public virtual int Sex { get; set; }

        /// <summary>
        /// 玩家形象
        /// </summary>
        public virtual int Image { get; set; }


        /// <summary>
        /// 角色等级
        /// </summary>
        public virtual int Level { get; set; }

        /// <summary>
        /// vip等级
        /// </summary>
        public virtual int VipLevel { get; set; }

        /// <summary>
        /// 角色创建时间
        /// </summary>
        public virtual long CreateDate { get; set; }


        public virtual CharacterBase  Base { get; set; }=new CharacterBase();

       
    }
}
