import React from 'react';
import '../i18n/language';
import { ThemeProvider } from '@material-ui/styles';
import { CssBaseline } from '@material-ui/core';
// eslint-disable-next-line no-unused-vars
import { withTranslation, useTranslation } from 'react-i18next';
import { useStateValue } from '../Context/StateProvider';

import myTheme from './Theme';
import AppBar from '../../Components/AppBar/AppBar';
import ConfigDrawer from '../../Components/ConfigDrawer/Drawer';
import Footer from '../../Components/Footer/Footer';
import useStyles from '../Styles';

const MyApp = (props: React.PropsWithChildren<any>): React.ReactElement => {
  const [{ Theme }] = useStateValue();
  const { children } = props;

  const classes = useStyles({});

  return (
    <ThemeProvider theme={myTheme(Theme)}>
      <div className={classes.body}>
        <AppBar />
        <div className={classes.main}>
          {children}
        </div>
        <Footer />
        <ConfigDrawer />
      </div>
      <CssBaseline />
    </ThemeProvider>
  );
};

export default withTranslation()(MyApp);