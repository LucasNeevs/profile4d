using Microsoft.Extensions.Options;
using System.Data;
using System.Data.SqlClient;
using Profile4d.Domain;

namespace Profile4d.Data
{
  public class StaticContent : IStaticContent
  {
    private readonly IOptions<Secrets.ConnectionStrings> _connStr;

    public StaticContent(IOptions<Secrets.ConnectionStrings> ConnectionStrings)
    {
      _connStr = ConnectionStrings;
    }

    public StaticFirstPage FirstPage()
    {
      StaticFirstPage _return = new StaticFirstPage();

      using (SqlConnection Con = new SqlConnection(_connStr.Value.SqlServer))
      {
        using (SqlCommand Cmd = new SqlCommand())
        {
          Cmd.CommandType = CommandType.StoredProcedure;
          Cmd.Connection = Con;
          Cmd.CommandText = "[sp_STATIC_FIRST_PAGE_READ]";

          Con.Open();

          using (SqlDataReader MyDR = Cmd.ExecuteReader())
          {
            MyDR.Read();

            _return.CreatedBy = MyDR.GetString(0);
            _return.Created = MyDR.GetDateTime(1).ToLongDateString();
            _return.Title_PT = MyDR.GetString(2);
            _return.Text_PT = MyDR.GetString(3);
            _return.Title_ENG = MyDR.GetString(4);
            _return.Text_ENG = MyDR.GetString(5);
          }
        }
      }

      _return.Success = true;

      return _return;
    }

    public BasicReturn FirstPageEdit(StaticFirstPage data)
    {
      BasicReturn _return = new BasicReturn();

      using (SqlConnection Con = new SqlConnection(_connStr.Value.SqlServer))
      {
        using (SqlCommand Cmd = new SqlCommand())
        {
          Cmd.CommandType = CommandType.StoredProcedure;
          Cmd.Connection = Con;
          Cmd.CommandText = "[sp_STATIC_FIRST_PAGE_EDIT]";

          Cmd.Parameters.AddWithValue("@USER", data.CreatedBy);
          Cmd.Parameters.AddWithValue("@TITLE_PT", data.Title_PT);
          Cmd.Parameters.AddWithValue("@TEXT_PT", data.Text_PT);
          Cmd.Parameters.AddWithValue("@TITLE_ENG", data.Title_ENG);
          Cmd.Parameters.AddWithValue("@TEXT_ENG", data.Text_ENG);

          Con.Open();

          Cmd.ExecuteNonQuery();
        }
      }

      _return.Success = true;

      return _return;
    }

    public StaticFirstPage CompetentMind()
    {
      StaticFirstPage _return = new StaticFirstPage();

      using (SqlConnection Con = new SqlConnection(_connStr.Value.SqlServer))
      {
        using (SqlCommand Cmd = new SqlCommand())
        {
          Cmd.CommandType = CommandType.StoredProcedure;
          Cmd.Connection = Con;
          Cmd.CommandText = "[sp_STATIC_COMPETENT_MIND_READ]";

          Con.Open();

          using (SqlDataReader MyDR = Cmd.ExecuteReader())
          {
            MyDR.Read();

            _return.CreatedBy = MyDR.GetString(0);
            _return.Created = MyDR.GetDateTime(1).ToLongDateString();
            _return.Title_PT = MyDR.GetString(2);
            _return.Text_PT = MyDR.GetString(3);
            _return.Title_ENG = MyDR.GetString(4);
            _return.Text_ENG = MyDR.GetString(5);
          }
        }
      }

      _return.Success = true;

      return _return;
    }

    public BasicReturn CompetentMindEdit(StaticFirstPage data)
    {
      BasicReturn _return = new BasicReturn();

      using (SqlConnection Con = new SqlConnection(_connStr.Value.SqlServer))
      {
        using (SqlCommand Cmd = new SqlCommand())
        {
          Cmd.CommandType = CommandType.StoredProcedure;
          Cmd.Connection = Con;
          Cmd.CommandText = "[sp_STATIC_COMPETENT_MIND_EDIT]";

          Cmd.Parameters.AddWithValue("@USER", data.CreatedBy);
          Cmd.Parameters.AddWithValue("@TITLE_PT", data.Title_PT);
          Cmd.Parameters.AddWithValue("@TEXT_PT", data.Text_PT);
          Cmd.Parameters.AddWithValue("@TITLE_ENG", data.Title_ENG);
          Cmd.Parameters.AddWithValue("@TEXT_ENG", data.Text_ENG);

          Con.Open();

          Cmd.ExecuteNonQuery();
        }
      }

      _return.Success = true;

      return _return;
    }

    public StaticFirstPage WhoIAm()
    {
      StaticFirstPage _return = new StaticFirstPage();

      using (SqlConnection Con = new SqlConnection(_connStr.Value.SqlServer))
      {
        using (SqlCommand Cmd = new SqlCommand())
        {
          Cmd.CommandType = CommandType.StoredProcedure;
          Cmd.Connection = Con;
          Cmd.CommandText = "[sp_STATIC_WHO_I_AM_READ]";

          Con.Open();

          using (SqlDataReader MyDR = Cmd.ExecuteReader())
          {
            MyDR.Read();

            _return.CreatedBy = MyDR.GetString(0);
            _return.Created = MyDR.GetDateTime(1).ToLongDateString();
            _return.Title_PT = MyDR.GetString(2);
            _return.Text_PT = MyDR.GetString(3);
            _return.Title_ENG = MyDR.GetString(4);
            _return.Text_ENG = MyDR.GetString(5);
          }
        }
      }

      _return.Success = true;

      return _return;
    }

    public BasicReturn WhoIAmEdit(StaticFirstPage data)
    {
      BasicReturn _return = new BasicReturn();

      using (SqlConnection Con = new SqlConnection(_connStr.Value.SqlServer))
      {
        using (SqlCommand Cmd = new SqlCommand())
        {
          Cmd.CommandType = CommandType.StoredProcedure;
          Cmd.Connection = Con;
          Cmd.CommandText = "[sp_STATIC_WHO_I_AM_EDIT]";

          Cmd.Parameters.AddWithValue("@USER", data.CreatedBy);
          Cmd.Parameters.AddWithValue("@TITLE_PT", data.Title_PT);
          Cmd.Parameters.AddWithValue("@TEXT_PT", data.Text_PT);
          Cmd.Parameters.AddWithValue("@TITLE_ENG", data.Title_ENG);
          Cmd.Parameters.AddWithValue("@TEXT_ENG", data.Text_ENG);

          Con.Open();

          Cmd.ExecuteNonQuery();
        }
      }

      _return.Success = true;

      return _return;
    }

    public StaticFirstPage DominantName()
    {
      StaticFirstPage _return = new StaticFirstPage();

      using (SqlConnection Con = new SqlConnection(_connStr.Value.SqlServer))
      {
        using (SqlCommand Cmd = new SqlCommand())
        {
          Cmd.CommandType = CommandType.StoredProcedure;
          Cmd.Connection = Con;
          Cmd.CommandText = "[sp_STATIC_DOMINANT_NAME_READ]";

          Con.Open();

          using (SqlDataReader MyDR = Cmd.ExecuteReader())
          {
            MyDR.Read();

            _return.CreatedBy = MyDR.GetString(0);
            _return.Created = MyDR.GetDateTime(1).ToLongDateString();
            _return.Title_PT = MyDR.GetString(2);
            _return.Text_PT = MyDR.GetString(3);
            _return.Title_ENG = MyDR.GetString(4);
            _return.Text_ENG = MyDR.GetString(5);
          }
        }
      }

      _return.Success = true;

      return _return;
    }

    public BasicReturn DominantNameEdit(StaticFirstPage data)
    {
      BasicReturn _return = new BasicReturn();

      using (SqlConnection Con = new SqlConnection(_connStr.Value.SqlServer))
      {
        using (SqlCommand Cmd = new SqlCommand())
        {
          Cmd.CommandType = CommandType.StoredProcedure;
          Cmd.Connection = Con;
          Cmd.CommandText = "[sp_STATIC_DOMINANT_NAME_EDIT]";

          Cmd.Parameters.AddWithValue("@USER", data.CreatedBy);
          Cmd.Parameters.AddWithValue("@TITLE_PT", data.Title_PT);
          Cmd.Parameters.AddWithValue("@TEXT_PT", data.Text_PT);
          Cmd.Parameters.AddWithValue("@TITLE_ENG", data.Title_ENG);
          Cmd.Parameters.AddWithValue("@TEXT_ENG", data.Text_ENG);

          Con.Open();

          Cmd.ExecuteNonQuery();
        }
      }

      _return.Success = true;

      return _return;
    }

    public StaticFirstPage DominantStructure()
    {
      StaticFirstPage _return = new StaticFirstPage();

      using (SqlConnection Con = new SqlConnection(_connStr.Value.SqlServer))
      {
        using (SqlCommand Cmd = new SqlCommand())
        {
          Cmd.CommandType = CommandType.StoredProcedure;
          Cmd.Connection = Con;
          Cmd.CommandText = "[sp_STATIC_DOMINANT_STRUCTURE_READ]";

          Con.Open();

          using (SqlDataReader MyDR = Cmd.ExecuteReader())
          {
            MyDR.Read();

            _return.CreatedBy = MyDR.GetString(0);
            _return.Created = MyDR.GetDateTime(1).ToLongDateString();
            _return.Title_PT = MyDR.GetString(2);
            _return.Text_PT = MyDR.GetString(3);
            _return.Title_ENG = MyDR.GetString(4);
            _return.Text_ENG = MyDR.GetString(5);
          }
        }
      }

      _return.Success = true;

      return _return;
    }

    public BasicReturn DominantStructureEdit(StaticFirstPage data)
    {
      BasicReturn _return = new BasicReturn();

      using (SqlConnection Con = new SqlConnection(_connStr.Value.SqlServer))
      {
        using (SqlCommand Cmd = new SqlCommand())
        {
          Cmd.CommandType = CommandType.StoredProcedure;
          Cmd.Connection = Con;
          Cmd.CommandText = "[sp_STATIC_DOMINANT_STRUCTURE_EDIT]";

          Cmd.Parameters.AddWithValue("@USER", data.CreatedBy);
          Cmd.Parameters.AddWithValue("@TITLE_PT", data.Title_PT);
          Cmd.Parameters.AddWithValue("@TEXT_PT", data.Text_PT);
          Cmd.Parameters.AddWithValue("@TITLE_ENG", data.Title_ENG);
          Cmd.Parameters.AddWithValue("@TEXT_ENG", data.Text_ENG);

          Con.Open();

          Cmd.ExecuteNonQuery();
        }
      }

      _return.Success = true;

      return _return;
    }

    public StaticFirstPage SabotageMode()
    {
      StaticFirstPage _return = new StaticFirstPage();

      using (SqlConnection Con = new SqlConnection(_connStr.Value.SqlServer))
      {
        using (SqlCommand Cmd = new SqlCommand())
        {
          Cmd.CommandType = CommandType.StoredProcedure;
          Cmd.Connection = Con;
          Cmd.CommandText = "[sp_STATIC_SABOTAGE_MODE_READ]";

          Con.Open();

          using (SqlDataReader MyDR = Cmd.ExecuteReader())
          {
            MyDR.Read();

            _return.CreatedBy = MyDR.GetString(0);
            _return.Created = MyDR.GetDateTime(1).ToLongDateString();
            _return.Title_PT = MyDR.GetString(2);
            _return.Text_PT = MyDR.GetString(3);
            _return.Title_ENG = MyDR.GetString(4);
            _return.Text_ENG = MyDR.GetString(5);
          }
        }
      }

      _return.Success = true;

      return _return;
    }

    public BasicReturn SabotageModeEdit(StaticFirstPage data)
    {
      BasicReturn _return = new BasicReturn();

      using (SqlConnection Con = new SqlConnection(_connStr.Value.SqlServer))
      {
        using (SqlCommand Cmd = new SqlCommand())
        {
          Cmd.CommandType = CommandType.StoredProcedure;
          Cmd.Connection = Con;
          Cmd.CommandText = "[sp_STATIC_SABOTAGE_MODE_EDIT]";

          Cmd.Parameters.AddWithValue("@USER", data.CreatedBy);
          Cmd.Parameters.AddWithValue("@TITLE_PT", data.Title_PT);
          Cmd.Parameters.AddWithValue("@TEXT_PT", data.Text_PT);
          Cmd.Parameters.AddWithValue("@TITLE_ENG", data.Title_ENG);
          Cmd.Parameters.AddWithValue("@TEXT_ENG", data.Text_ENG);

          Con.Open();

          Cmd.ExecuteNonQuery();
        }
      }

      _return.Success = true;

      return _return;
    }

    public StaticFirstPage SabotageWhoIAm()
    {
      StaticFirstPage _return = new StaticFirstPage();

      using (SqlConnection Con = new SqlConnection(_connStr.Value.SqlServer))
      {
        using (SqlCommand Cmd = new SqlCommand())
        {
          Cmd.CommandType = CommandType.StoredProcedure;
          Cmd.Connection = Con;
          Cmd.CommandText = "[sp_STATIC_SABOTAGE_WHO_I_AM_READ]";

          Con.Open();

          using (SqlDataReader MyDR = Cmd.ExecuteReader())
          {
            MyDR.Read();

            _return.CreatedBy = MyDR.GetString(0);
            _return.Created = MyDR.GetDateTime(1).ToLongDateString();
            _return.Title_PT = MyDR.GetString(2);
            _return.Text_PT = MyDR.GetString(3);
            _return.Title_ENG = MyDR.GetString(4);
            _return.Text_ENG = MyDR.GetString(5);
          }
        }
      }

      _return.Success = true;

      return _return;
    }

    public BasicReturn SabotageWhoIAmEdit(StaticFirstPage data)
    {
      BasicReturn _return = new BasicReturn();

      using (SqlConnection Con = new SqlConnection(_connStr.Value.SqlServer))
      {
        using (SqlCommand Cmd = new SqlCommand())
        {
          Cmd.CommandType = CommandType.StoredProcedure;
          Cmd.Connection = Con;
          Cmd.CommandText = "[sp_STATIC_SABOTAGE_WHO_I_AM_EDIT]";

          Cmd.Parameters.AddWithValue("@USER", data.CreatedBy);
          Cmd.Parameters.AddWithValue("@TITLE_PT", data.Title_PT);
          Cmd.Parameters.AddWithValue("@TEXT_PT", data.Text_PT);
          Cmd.Parameters.AddWithValue("@TITLE_ENG", data.Title_ENG);
          Cmd.Parameters.AddWithValue("@TEXT_ENG", data.Text_ENG);

          Con.Open();

          Cmd.ExecuteNonQuery();
        }
      }

      _return.Success = true;

      return _return;
    }

    public StaticFirstPage SabotageDominant()
    {
      StaticFirstPage _return = new StaticFirstPage();

      using (SqlConnection Con = new SqlConnection(_connStr.Value.SqlServer))
      {
        using (SqlCommand Cmd = new SqlCommand())
        {
          Cmd.CommandType = CommandType.StoredProcedure;
          Cmd.Connection = Con;
          Cmd.CommandText = "[sp_STATIC_SABOTAGE_DOMINANT_READ]";

          Con.Open();

          using (SqlDataReader MyDR = Cmd.ExecuteReader())
          {
            MyDR.Read();

            _return.CreatedBy = MyDR.GetString(0);
            _return.Created = MyDR.GetDateTime(1).ToLongDateString();
            _return.Title_PT = MyDR.GetString(2);
            _return.Text_PT = MyDR.GetString(3);
            _return.Title_ENG = MyDR.GetString(4);
            _return.Text_ENG = MyDR.GetString(5);
          }
        }
      }

      _return.Success = true;

      return _return;
    }

    public BasicReturn SabotageDominantEdit(StaticFirstPage data)
    {
      BasicReturn _return = new BasicReturn();

      using (SqlConnection Con = new SqlConnection(_connStr.Value.SqlServer))
      {
        using (SqlCommand Cmd = new SqlCommand())
        {
          Cmd.CommandType = CommandType.StoredProcedure;
          Cmd.Connection = Con;
          Cmd.CommandText = "[sp_STATIC_SABOTAGE_DOMINANT_EDIT]";

          Cmd.Parameters.AddWithValue("@USER", data.CreatedBy);
          Cmd.Parameters.AddWithValue("@TITLE_PT", data.Title_PT);
          Cmd.Parameters.AddWithValue("@TEXT_PT", data.Text_PT);
          Cmd.Parameters.AddWithValue("@TITLE_ENG", data.Title_ENG);
          Cmd.Parameters.AddWithValue("@TEXT_ENG", data.Text_ENG);

          Con.Open();

          Cmd.ExecuteNonQuery();
        }
      }

      _return.Success = true;

      return _return;
    }

    public StaticFirstPage SabotageName()
    {
      StaticFirstPage _return = new StaticFirstPage();

      using (SqlConnection Con = new SqlConnection(_connStr.Value.SqlServer))
      {
        using (SqlCommand Cmd = new SqlCommand())
        {
          Cmd.CommandType = CommandType.StoredProcedure;
          Cmd.Connection = Con;
          Cmd.CommandText = "[sp_STATIC_SABOTAGE_NAME_READ]";

          Con.Open();

          using (SqlDataReader MyDR = Cmd.ExecuteReader())
          {
            MyDR.Read();

            _return.CreatedBy = MyDR.GetString(0);
            _return.Created = MyDR.GetDateTime(1).ToLongDateString();
            _return.Title_PT = MyDR.GetString(2);
            _return.Text_PT = MyDR.GetString(3);
            _return.Title_ENG = MyDR.GetString(4);
            _return.Text_ENG = MyDR.GetString(5);
          }
        }
      }

      _return.Success = true;

      return _return;
    }

    public BasicReturn SabotageNameEdit(StaticFirstPage data)
    {
      BasicReturn _return = new BasicReturn();

      using (SqlConnection Con = new SqlConnection(_connStr.Value.SqlServer))
      {
        using (SqlCommand Cmd = new SqlCommand())
        {
          Cmd.CommandType = CommandType.StoredProcedure;
          Cmd.Connection = Con;
          Cmd.CommandText = "[sp_STATIC_SABOTAGE_NAME_EDIT]";

          Cmd.Parameters.AddWithValue("@USER", data.CreatedBy);
          Cmd.Parameters.AddWithValue("@TITLE_PT", data.Title_PT);
          Cmd.Parameters.AddWithValue("@TEXT_PT", data.Text_PT);
          Cmd.Parameters.AddWithValue("@TITLE_ENG", data.Title_ENG);
          Cmd.Parameters.AddWithValue("@TEXT_ENG", data.Text_ENG);

          Con.Open();

          Cmd.ExecuteNonQuery();
        }
      }

      _return.Success = true;

      return _return;
    }

    public StaticFirstPage CompetentXSabotage()
    {
      StaticFirstPage _return = new StaticFirstPage();

      using (SqlConnection Con = new SqlConnection(_connStr.Value.SqlServer))
      {
        using (SqlCommand Cmd = new SqlCommand())
        {
          Cmd.CommandType = CommandType.StoredProcedure;
          Cmd.Connection = Con;
          Cmd.CommandText = "[sp_STATIC_COMPETENT_SABOTAGE_READ]";

          Con.Open();

          using (SqlDataReader MyDR = Cmd.ExecuteReader())
          {
            MyDR.Read();

            _return.CreatedBy = MyDR.GetString(0);
            _return.Created = MyDR.GetDateTime(1).ToLongDateString();
            _return.Title_PT = MyDR.GetString(2);
            _return.Text_PT = MyDR.GetString(3);
            _return.Title_ENG = MyDR.GetString(4);
            _return.Text_ENG = MyDR.GetString(5);
          }
        }
      }

      _return.Success = true;

      return _return;
    }

    public BasicReturn CompetentXSabotageEdit(StaticFirstPage data)
    {
      BasicReturn _return = new BasicReturn();

      using (SqlConnection Con = new SqlConnection(_connStr.Value.SqlServer))
      {
        using (SqlCommand Cmd = new SqlCommand())
        {
          Cmd.CommandType = CommandType.StoredProcedure;
          Cmd.Connection = Con;
          Cmd.CommandText = "[sp_STATIC_COMPETENT_SABOTAGE_EDIT]";

          Cmd.Parameters.AddWithValue("@USER", data.CreatedBy);
          Cmd.Parameters.AddWithValue("@TITLE_PT", data.Title_PT);
          Cmd.Parameters.AddWithValue("@TEXT_PT", data.Text_PT);
          Cmd.Parameters.AddWithValue("@TITLE_ENG", data.Title_ENG);
          Cmd.Parameters.AddWithValue("@TEXT_ENG", data.Text_ENG);

          Con.Open();

          Cmd.ExecuteNonQuery();
        }
      }

      _return.Success = true;

      return _return;
    }

    public StaticFirstPage TrinityBehavioralCompetent()
    {
      StaticFirstPage _return = new StaticFirstPage();

      using (SqlConnection Con = new SqlConnection(_connStr.Value.SqlServer))
      {
        using (SqlCommand Cmd = new SqlCommand())
        {
          Cmd.CommandType = CommandType.StoredProcedure;
          Cmd.Connection = Con;
          Cmd.CommandText = "[sp_STATIC_TRINITY_BEHAVIORAL_READ]";

          Con.Open();

          using (SqlDataReader MyDR = Cmd.ExecuteReader())
          {
            MyDR.Read();

            _return.CreatedBy = MyDR.GetString(0);
            _return.Created = MyDR.GetDateTime(1).ToLongDateString();
            _return.Title_PT = MyDR.GetString(2);
            _return.Text_PT = MyDR.GetString(3);
            _return.Title_ENG = MyDR.GetString(4);
            _return.Text_ENG = MyDR.GetString(5);
          }
        }
      }

      _return.Success = true;

      return _return;
    }

    public BasicReturn TrinityBehavioralCompetentEdit(StaticFirstPage data)
    {
      BasicReturn _return = new BasicReturn();

      using (SqlConnection Con = new SqlConnection(_connStr.Value.SqlServer))
      {
        using (SqlCommand Cmd = new SqlCommand())
        {
          Cmd.CommandType = CommandType.StoredProcedure;
          Cmd.Connection = Con;
          Cmd.CommandText = "[sp_STATIC_TRINITY_BEHAVIORAL_EDIT]";

          Cmd.Parameters.AddWithValue("@USER", data.CreatedBy);
          Cmd.Parameters.AddWithValue("@TITLE_PT", data.Title_PT);
          Cmd.Parameters.AddWithValue("@TEXT_PT", data.Text_PT);
          Cmd.Parameters.AddWithValue("@TITLE_ENG", data.Title_ENG);
          Cmd.Parameters.AddWithValue("@TEXT_ENG", data.Text_ENG);

          Con.Open();

          Cmd.ExecuteNonQuery();
        }
      }

      _return.Success = true;

      return _return;
    }

    public StaticFirstPage InternalPartners()
    {
      StaticFirstPage _return = new StaticFirstPage();

      using (SqlConnection Con = new SqlConnection(_connStr.Value.SqlServer))
      {
        using (SqlCommand Cmd = new SqlCommand())
        {
          Cmd.CommandType = CommandType.StoredProcedure;
          Cmd.Connection = Con;
          Cmd.CommandText = "[sp_STATIC_INTERNAL_PARTNERS_READ]";

          Con.Open();

          using (SqlDataReader MyDR = Cmd.ExecuteReader())
          {
            MyDR.Read();

            _return.CreatedBy = MyDR.GetString(0);
            _return.Created = MyDR.GetDateTime(1).ToLongDateString();
            _return.Title_PT = MyDR.GetString(2);
            _return.Text_PT = MyDR.GetString(3);
            _return.Title_ENG = MyDR.GetString(4);
            _return.Text_ENG = MyDR.GetString(5);
          }
        }
      }

      _return.Success = true;

      return _return;
    }

    public BasicReturn InternalPartnersEdit(StaticFirstPage data)
    {
      BasicReturn _return = new BasicReturn();

      using (SqlConnection Con = new SqlConnection(_connStr.Value.SqlServer))
      {
        using (SqlCommand Cmd = new SqlCommand())
        {
          Cmd.CommandType = CommandType.StoredProcedure;
          Cmd.Connection = Con;
          Cmd.CommandText = "[sp_STATIC_INTERNAL_PARTNERS_EDIT]";

          Cmd.Parameters.AddWithValue("@USER", data.CreatedBy);
          Cmd.Parameters.AddWithValue("@TITLE_PT", data.Title_PT);
          Cmd.Parameters.AddWithValue("@TEXT_PT", data.Text_PT);
          Cmd.Parameters.AddWithValue("@TITLE_ENG", data.Title_ENG);
          Cmd.Parameters.AddWithValue("@TEXT_ENG", data.Text_ENG);

          Con.Open();

          Cmd.ExecuteNonQuery();
        }
      }

      _return.Success = true;

      return _return;
    }

    public StaticFirstPage IntNamePartnerOne()
    {
      StaticFirstPage _return = new StaticFirstPage();

      using (SqlConnection Con = new SqlConnection(_connStr.Value.SqlServer))
      {
        using (SqlCommand Cmd = new SqlCommand())
        {
          Cmd.CommandType = CommandType.StoredProcedure;
          Cmd.Connection = Con;
          Cmd.CommandText = "[sp_STATIC_INTERNAL_PARTNER_ONE_READ]";

          Con.Open();

          using (SqlDataReader MyDR = Cmd.ExecuteReader())
          {
            MyDR.Read();

            _return.CreatedBy = MyDR.GetString(0);
            _return.Created = MyDR.GetDateTime(1).ToLongDateString();
            _return.Title_PT = MyDR.GetString(2);
            _return.Text_PT = MyDR.GetString(3);
            _return.Title_ENG = MyDR.GetString(4);
            _return.Text_ENG = MyDR.GetString(5);
          }
        }
      }

      _return.Success = true;

      return _return;
    }

    public BasicReturn IntNamePartnerOneEdit(StaticFirstPage data)
    {
      BasicReturn _return = new BasicReturn();

      using (SqlConnection Con = new SqlConnection(_connStr.Value.SqlServer))
      {
        using (SqlCommand Cmd = new SqlCommand())
        {
          Cmd.CommandType = CommandType.StoredProcedure;
          Cmd.Connection = Con;
          Cmd.CommandText = "[sp_STATIC_INTERNAL_PARTNER_ONE_EDIT]";

          Cmd.Parameters.AddWithValue("@USER", data.CreatedBy);
          Cmd.Parameters.AddWithValue("@TITLE_PT", data.Title_PT);
          Cmd.Parameters.AddWithValue("@TEXT_PT", data.Text_PT);
          Cmd.Parameters.AddWithValue("@TITLE_ENG", data.Title_ENG);
          Cmd.Parameters.AddWithValue("@TEXT_ENG", data.Text_ENG);

          Con.Open();

          Cmd.ExecuteNonQuery();
        }
      }

      _return.Success = true;

      return _return;
    }
  }
}