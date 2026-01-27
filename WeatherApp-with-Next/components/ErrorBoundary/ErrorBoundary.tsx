'use client'
import './ErrorBoundary.css';

import { Component, ErrorInfo, ReactNode } from 'react';
import { FaExclamationTriangle } from 'react-icons/fa';

interface Props {
  children?: ReactNode;
}

interface State {
  hasError: boolean;
  error: string;
}

class ErrorBoundary extends Component<Props, State> {

  constructor(props: Props) {
    super(props);
    this.state = { hasError: false, error: '' };
  }

  public static getDerivedStateFromError(err: Error): State {
    return { hasError: true, error: err.message };
  }

  public componentDidCatch(error: Error, errorInfo: ErrorInfo): void {
    console.error('Appliction error:', error, errorInfo);
    this.setState({ hasError: true, error: error.message });
  }

  public render() {
    if (this.state.hasError) {
      return (
        <div 
          className="border-2 rounded-lg p-2 flex text-center items-center justify-center gap-2 rounded-lg text-4xl" 
          id="error"
        >
          <FaExclamationTriangle size={120}/>
          <div>
            <h3 className="flex text-center items-center justify-center gap-2 rounded-lg text-5xl">
              Application Error!
            </h3>
            <h3 className="flex text-center items-center justify-center gap-2 rounded-lg text-4xl">
              {this.state.error}
            </h3>
          </div>
        </div>
      );
    }

    return this.props.children;
  }
}

export default ErrorBoundary;