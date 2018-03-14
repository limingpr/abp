using System;
using Volo.Abp.Auditing;

namespace Volo.Abp.Domain.Entities.Auditing
{
    /// <summary>
    /// Implements <see cref="IFullAudited{TUser}"/> to be a base class for full-audited entities.
    /// </summary>
    /// <typeparam name="TUser">Type of the user</typeparam>
    [Serializable]
    public abstract class FullAuditedEntityWithUser<TUser> : FullAuditedEntity, IFullAudited<TUser>
        where TUser : IEntity<long>
    {
        /// <inheritdoc />
        public virtual TUser DeleterUser { get; set; }

        /// <inheritdoc />
        public TUser CreatorUser { get; set; }

        /// <inheritdoc />
        public TUser LastModifierUser { get; set; }
    }

    /// <summary>
    /// Implements <see cref="IFullAudited{TUser}"/> to be a base class for full-audited entities.
    /// </summary>
    /// <typeparam name="TPrimaryKey">Type of the primary key of the entity</typeparam>
    /// <typeparam name="TUser">Type of the user</typeparam>
    [Serializable]
    public abstract class FullAuditedEntityWithUser<TPrimaryKey, TUser> : FullAuditedEntity<TPrimaryKey>, IFullAudited<TUser>
        where TUser : IEntity<long>
    {
        /// <inheritdoc />
        public virtual TUser DeleterUser { get; set; }

        /// <inheritdoc />
        public TUser CreatorUser { get; set; }
        
        /// <inheritdoc />
        public TUser LastModifierUser { get; set; }
    }
}