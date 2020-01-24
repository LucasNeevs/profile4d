import React from 'react';
import { NavLink } from 'react-router-dom';
// eslint-disable-next-line no-unused-vars
import { withTranslation, WithTranslation } from 'react-i18next';
import {
  ListItem, ListSubheader, ListItemText, List,
} from '@material-ui/core';
import setLanguage from './Language';
import Styles from './Styles';

export default withTranslation()(
  (props: WithTranslation): React.ReactElement<WithTranslation> => {
    const { t } = props;
    const classes = Styles({});
    setLanguage();

    return (
      <List
        component="nav"
        aria-labelledby="fixed-content-header"
        subheader={
          (
            <ListSubheader component="div" id="fixed-content-header">
              {t('DrawerAdminFixed:title')}
            </ListSubheader>
        )}
        className={classes.root}
      >
        <ListItem button component={NavLink} to="/fixedcontent/firstpage" title="Primeira página">
          <ListItemText primary="Primeira página" />
        </ListItem>
      </List>
    );
  },
);
