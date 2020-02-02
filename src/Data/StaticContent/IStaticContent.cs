using Profile4d.Domain;

namespace Profile4d.Data
{
  public interface IStaticContent
  {
    public StaticFirstPage FirstPage();
    public BasicReturn FirstPageEdit(StaticFirstPage data);

    public StaticFirstPage CompetentMind();
    public BasicReturn CompetentMindEdit(StaticFirstPage data);

    public StaticFirstPage WhoIAm();
    public BasicReturn WhoIAmEdit(StaticFirstPage data);

    public StaticFirstPage DominantName();
    public BasicReturn DominantNameEdit(StaticFirstPage data);

    public StaticFirstPage DominantStructure();
    public BasicReturn DominantStructureEdit(StaticFirstPage data);

    public StaticFirstPage SabotageMode();
    public BasicReturn SabotageModeEdit(StaticFirstPage data);

    public StaticFirstPage SabotageWhoIAm();
    public BasicReturn SabotageWhoIAmEdit(StaticFirstPage data);

    public StaticFirstPage SabotageDominant();
    public BasicReturn SabotageDominantEdit(StaticFirstPage data);

    public StaticFirstPage SabotageName();
    public BasicReturn SabotageNameEdit(StaticFirstPage data);

    public StaticFirstPage CompetentXSabotage();
    public BasicReturn CompetentXSabotageEdit(StaticFirstPage data);

    public StaticFirstPage TrinityBehavioralCompetent();
    public BasicReturn TrinityBehavioralCompetentEdit(StaticFirstPage data);

    public StaticFirstPage InternalPartners();
    public BasicReturn InternalPartnersEdit(StaticFirstPage data);

    public StaticFirstPage IntNamePartnerOne();
    public BasicReturn IntNamePartnerOneEdit(StaticFirstPage data);
  }
}