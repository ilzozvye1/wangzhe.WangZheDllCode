using System;

namespace ResData
{
	public enum ResSkillCombineEffectSubType
	{
		SKILL_COMBINE_SUBTYPE_NONE,
		SKILL_COMBINE_SUBTYPE_PROTECT_PHYSHURT,
		SKILL_COMBINE_SUBTYPE_PROTECT_MAGICHURT,
		SKILL_COMBINE_SUBTYPE_PROTECT_ALL,
		SKILL_COMBINE_SUBTYPE_NOPHYSHURT,
		SKILL_COMBINE_SUBTYPE_NOMAGICHURT,
		SKILL_COMBINE_SUBTYPE_NOHURT,
		SKILL_COMBINE_SUBTYPE_EXTRAEFFECT,
		SKILL_COMBINE_SUBTYPE_CONDITION,
		SKILL_COMBINE_SUBTYPE_BOUNCEHURT,
		SKILL_COMBINE_SUBTYPE_STUN,
		SKILL_COMBINE_SUBTYPE_PROTECT_ALL_INCLUDE_REALHURT
	}
}