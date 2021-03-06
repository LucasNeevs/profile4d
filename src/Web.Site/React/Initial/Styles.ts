// eslint-disable-next-line no-unused-vars
import { makeStyles, Theme } from '@material-ui/core';

interface IStyles {
  body: {},
  main: {},
}

export default makeStyles((theme: Theme): IStyles => ({
  body: {
    display: 'flex',
    flexDirection: 'column',
    minHeight: '100vh',
  },
  main: {
    flexGrow: 1,
    marginTop: '65px',
    marginBotton: theme.spacing(6),
    paddingTop: theme.spacing(0),
    paddingBottom: theme.spacing(2),
    flexDirection: 'column',
    justifyContent: 'flex-start',
    alignItems: 'stretch',
    alignContent: 'stretch',
  },
}));
