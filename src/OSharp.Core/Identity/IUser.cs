﻿// -----------------------------------------------------------------------
//  <copyright file="IUser.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2015 OSharp. All rights reserved.
//  </copyright>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2015-06-16 22:03</last-date>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OSharp.Core.Identity
{
    /// <summary>
    /// 用户接口，最小化用户信息
    /// </summary>
    public interface IUser<out TKey>
    {
        /// <summary>
        /// 获取 角色编号
        /// </summary>
        TKey Id { get; }

        /// <summary>
        /// 获取 用户名
        /// </summary>
        string Name { get; }

        /// <summary>
        /// 获取 用户昵称
        /// </summary>
        string NickName { get; }
    }
}