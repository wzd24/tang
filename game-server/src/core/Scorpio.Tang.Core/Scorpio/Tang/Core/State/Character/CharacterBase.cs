namespace Scorpio.Tang.Core.State.Character
{
    public record CharacterBase
    {
        /// <summary>
        /// 已解锁形象ID列表
        /// </summary>
        public virtual List<int> UnlockedImages { get; set; } = [];

        /// <summary>
        /// 剧情关卡
        /// </summary>
        public virtual int PlotLevel { get; set; }

        /// <summary>
        /// 地址ID 默认配置地址取杂项配置1100000
        /// </summary>
        public virtual int AddressId { get; set; }
        /// <summary>
        /// 地址修改状态
        /// </summary>
        public virtual bool AddressChangeState { get; set; }

        /// <summary>
        /// 当前穿戴头像框ID
        /// </summary>
        public virtual int HeadFrameId { get; set; }

        /// <summary>
        /// 已解锁头像框ID列表 key 头像框ID value 过期时间戳
        /// </summary>
        public virtual Dictionary<int, long> UnLockedHeadFrames { get; set; } = [];

        /// <summary>
        /// 当前穿戴头像ID
        /// </summary>
        public virtual int HeadId { get; set; }

        /// <summary>
        /// 已解锁头像ID列表
        /// </summary>
        public virtual List<int> UnlockedHeads { get; set; } = [];

        /// <summary>
        /// 玩家默认头像
        /// </summary>
        public virtual int DefHead { get; set; }

        /// <summary>
        /// 当前穿戴称号ID
        /// </summary>
        public virtual int TitleId { get; set; }

        /// <summary>
        /// 当前穿戴时装ID
        /// </summary>
        public virtual int FashionId { get; set; }

        /// <summary>
        /// 已解锁时装 key 时装ID value 等级
        /// </summary>
        public virtual Dictionary<int, int> UnlockedFashions { get; set; } = [];

       
    }

  
}
